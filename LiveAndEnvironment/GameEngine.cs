using System;
using System.Collections.Generic;

namespace LiveAndEnvironment
{
    public class GameEngine
    {
        int _mapWidth;
        int _mapHeight;
        public Cell[,] Map { get; private set; }
        
        List<Unit> _units;
        List<Unit> _bornUnits;

        Random _random = new Random();
        
        const int EVOLUTION_CHANCE = 10;

        public GameEngine(int width, int height)
        {
            _mapWidth = width;
            _mapHeight = height;
            Map = new Cell[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Map[i, j] = new Cell(null, j, i);
                }
            }

            _units = new List<Unit>();
            _bornUnits = new List<Unit>();
        }

        private void GrowUnits()
        {
            foreach (var unit in _units)
            {
                unit.Grow();
            }
        }

        private void EnvironmentDamage()
        {
            foreach (var unit in _units)
            {
                unit.EnvironmentDamage();
            }
        }

        private List<Cell> GetCellsAround(Unit unit, double radius)
        {
            List<Cell> result = new List<Cell>();

            for (int i = unit.Cell.Y - (int)Math.Round(radius); i <= unit.Cell.Y + (int)Math.Round(radius); i++)
            {
                if (i >= 0 && i < _mapHeight)
                {
                    for (int j = unit.Cell.X - (int)Math.Round(radius); j <= unit.Cell.X + (int)Math.Round(radius); j++)
                    {
                        if (j >= 0 && j < _mapWidth)
                        {
                            if (Math.Pow(unit.Cell.X - j, 2) + Math.Pow(unit.Cell.Y - i, 2) <= radius * radius)
                            {
                                result.Add(Map[i, j]);
                            }
                        }
                    }
                }
            }

            return result;
        }

        private void BornUnit(Unit parent)
        {
            List<Cell> cellsAround = GetCellsAround(parent, 1.45);
            List<Cell> freeCells = new List<Cell>();

            foreach (var item in cellsAround)
            {
                if (item.Unit == null)
                {
                    freeCells.Add(item);
                }
            }

            if (freeCells.Count > 0)
            {
                Cell bornCell = freeCells[_random.Next(freeCells.Count)];
                Species species = parent.Species;

                if (_random.Next(EVOLUTION_CHANCE) == EVOLUTION_CHANCE / 2)
                {
                    species = species.Evolve();
                }
                Unit newUnit = new Unit(species, bornCell);
                _bornUnits.Add(newUnit);

                parent.State = UnitState.Wander;
                parent.Mass -= newUnit.Mass;
                parent.ReproductionProgress -= parent.Species.ReproductionMass;
            }
            else
            {
                parent.CannotBornTimes++;
                if (parent.CannotBornTimes >= 3)//reborn
                {
                    Species species = parent.Species;

                    if (_random.Next(EVOLUTION_CHANCE) == EVOLUTION_CHANCE / 2)
                    {
                        species = species.Evolve();
                    }

                    Unit newUnit = new Unit(species, parent.Cell);
                    _bornUnits.Add(newUnit);

                    parent.State = UnitState.Wander;
                    parent.Mass = -1;
                    parent.ReproductionProgress = 0;
                }
            }
        }

        private void UnitsDo()
        {
            foreach (var unit in _units)
            {
                List<Cell> sensoredCells = GetCellsAround(unit, unit.Species.SensorRadius);
                Cell target = null;

                if (unit.State == UnitState.Reproduction)
                {
                    if (unit.Mass < unit.Species.ReproductionMass)
                    {
                        unit.ReproductionProgress = 0;
                        unit.State = UnitState.Wander;
                    }
                }
                if (unit.Mass >= unit.Species.ReproductionMass)
                {
                    unit.State = UnitState.Reproduction;
                }

                if (unit.State == UnitState.Wander)
                {
                    double targetDistance = double.MaxValue;
                    foreach (var item in sensoredCells)
                    {
                        if (item.Unit != null)
                        {
                            if (unit.Species.FoodList.Contains(item.Unit.Species.FoodType))
                            {
                                double distance = Math.Pow(unit.Cell.X - item.X, 2) + Math.Pow(unit.Cell.Y - item.Y, 2);
                                if (distance < targetDistance)
                                {
                                    target = item;
                                    targetDistance = distance;
                                }
                            }
                        }
                    }

                    double direction;
                    if (target != null)
                    {
                        direction = Math.Atan2(unit.Cell.Y - target.Y, target.X - unit.Cell.X);
                    }
                    else
                    {
                        direction = _random.NextDouble() * Math.PI * 2;
                    }

                    double dx = unit.Species.Speed * Math.Cos(direction);
                    double dy = unit.Species.Speed * -Math.Sin(direction);
                    unit.LocalX += dx;
                    unit.LocalY += dy;
                }
                else if (unit.State == UnitState.Reproduction)
                {
                    if (unit.ReproductionProgress >= unit.Species.ReproductionMass)
                    {
                        BornUnit(unit);
                    }
                    else //reproduction in progress
                    {
                        unit.ReproductionProgress += unit.Species.ReproductionSpeed;
                    }
                }

                List<Cell> EatRangeCells = GetCellsAround(unit, 1.45);
                if (EatRangeCells.Contains(target))//Attack
                {
                    unit.Attack(target.Unit);
                }
            }

            _units.AddRange(_bornUnits);
            _bornUnits.Clear();
        }

        private void DieUnits()
        {
            List<Unit> deadList = new List<Unit>();
            foreach (var unit in _units)
            {
                if (unit.IsLive == false)
                {
                    deadList.Add(unit);
                }
            }
            foreach (var dead in deadList)
            {
                _units.Remove(dead);
                if (dead.Cell.Unit == dead)
                {
                    dead.Cell.Unit = null;
                }
                dead.Species.DecrementLiveBeing();
                dead.Species.CheckExtinction();
            }
        }

        private void TryMoveUnit(Unit unit)
        {
            while (unit.LocalX < 0 || unit.LocalX > 1 || unit.LocalY < 0 || unit.LocalY > 1)
            {
                int dx = 0;
                int dy = 0;

                if (unit.LocalX < 0)
                {
                    dx = -1;
                }
                if (unit.LocalX > 1)
                {
                    dx = 1;
                }
                if (unit.LocalY < 0)
                {
                    dy = -1;
                }
                if (unit.LocalY > 1)
                {
                    dy = 1;
                }

                if (unit.Cell.X + dx < 0)
                {
                    dx = 0;
                    unit.LocalX = 0;
                }
                if (unit.Cell.X + dx >= _mapWidth)
                {
                    dx = 0;
                    unit.LocalX = 1;
                }
                if (unit.Cell.Y + dy < 0)
                {
                    dy = 0;
                    unit.LocalY = 0;
                }
                if (unit.Cell.Y + dy >= _mapHeight)
                {
                    dy = 0;
                    unit.LocalY = 1;
                }

                if (Map[unit.Cell.Y + dy, unit.Cell.X + dx].Unit == null)
                {
                    unit.Cell.Unit = null;
                    unit.Cell = Map[unit.Cell.Y + dy, unit.Cell.X + dx];
                    unit.Cell.Unit = unit;

                }
                if (unit.LocalX < 0)
                {
                    unit.LocalX += 1;
                }
                if (unit.LocalX > 1)
                {
                    unit.LocalX -= 1;
                }
                if (unit.LocalY < 0)
                {
                    unit.LocalY += 1;
                }
                if (unit.LocalY > 1)
                {
                    unit.LocalY -= 1;
                }
            }
        }

        private void MoveUnits()
        {
            foreach (var unit in _units)
            {
                TryMoveUnit(unit);
            }
        }

        public void Turn()
        {
            GrowUnits();
            EnvironmentDamage();
            UnitsDo();
            DieUnits();
            MoveUnits();
        }

        public void AddUnit(Unit unit)
        {
            _units.Add(unit);
        }
    }
}

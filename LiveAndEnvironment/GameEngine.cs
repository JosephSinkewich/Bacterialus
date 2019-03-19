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

        #region(Evolve constants)
        const int EVOLUTION_CHANCE = 1000;
        const double INFLUENCE_MAX_EVOLVE = 0.1;
        const double SPEED_MAX_EVOLVE = 0.1;
        const double REPRODUCTION_SPEED_MAX_EVOLVE = 0.4;
        const double EAT_SPEED_MAX_EVOLVE = 0.3;
        const double REPRODUCTION_MASS_MAX_EVOLVE = 0.2;
        const double SENSOR_MAX_EVOLVE = 0.2;
        #endregion

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

        public Species Evolve(Species parent)
        {
            Species descendant = new Species(parent);
            
            bool addSomething = Convert.ToBoolean(_random.Next(2));

            int propertyNumber = _random.Next(11);

            if (propertyNumber == 0)//Adaptations
            {
                if (EnvironmentType.AllEnvironments.Count > 0)
                {
                    EnvironmentType environmentType =
                        EnvironmentType.AllEnvironments[_random.Next(EnvironmentType.AllEnvironments.Count)];
                    double influence = _random.NextDouble() * INFLUENCE_MAX_EVOLVE;
                    if (!addSomething)
                    {
                        influence = -influence;
                    }

                    Adaptation adaptation = new Adaptation(environmentType, influence);
                    descendant.AddAdaptation(adaptation);
                }
            }
            else if (propertyNumber == 1)//Speed
            {
                if (addSomething)
                {
                    descendant.Speed += _random.NextDouble() * SPEED_MAX_EVOLVE;
                }
                else
                {
                    descendant.Speed -= _random.NextDouble() * SPEED_MAX_EVOLVE;
                }
            }
            else if (propertyNumber == 2)//EatList
            {
                if (addSomething)
                {
                    Species food = null;
                    food = Species.AllLiveSpecies[_random.Next(Species.AllLiveSpecies.Count)];
                    if (food != descendant)
                    {
                        descendant.EatList.Add(food);
                    }
                }
                else
                {
                    Species speciesToDelete = null;
                    foreach (var item in descendant.EatList)
                    {
                        if (_random.Next(descendant.EatList.Count) == 0)
                        {
                            speciesToDelete = item;
                            break;
                        }
                    }
                    descendant.EatList.Remove(speciesToDelete);
                }
            }
            else if (propertyNumber == 4)//ReproductionSpeed
            {
                if (addSomething)
                {
                    descendant.ReproductionSpeed += _random.NextDouble() * REPRODUCTION_SPEED_MAX_EVOLVE;
                }
                else
                {
                    descendant.ReproductionSpeed -= _random.NextDouble() * REPRODUCTION_SPEED_MAX_EVOLVE;
                }
            }
            else if (propertyNumber == 5)//Mass
            {
                if (addSomething)
                {
                    descendant.ReproductionMass += _random.NextDouble() * REPRODUCTION_MASS_MAX_EVOLVE;
                }
                else
                {
                    descendant.ReproductionMass -= _random.NextDouble() * REPRODUCTION_MASS_MAX_EVOLVE;
                }
            }
            else if (propertyNumber == 6)//Behavior
            {
                //may be later
            }
            else if (propertyNumber == 7)//DangerList
            {
                //may be later
            }
            else if (propertyNumber == 8)//SensorRadius
            {
                if (addSomething)
                {
                    descendant.SensorRadius += _random.NextDouble() * SENSOR_MAX_EVOLVE;
                }
                else
                {
                    descendant.SensorRadius -= _random.NextDouble() * SENSOR_MAX_EVOLVE;
                }
            }
            else if (propertyNumber == 9)//FavorEnvironments
            {
                //may be later
            }
            else if (propertyNumber == 10)//EatSpeed
            {
                if (addSomething)
                {
                    descendant.EatSpeed += _random.NextDouble() * EAT_SPEED_MAX_EVOLVE;
                }
                else
                {
                    descendant.EatSpeed -= _random.NextDouble() * EAT_SPEED_MAX_EVOLVE;
                }
            }

            return descendant;
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
                    species = Evolve(species);
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
                if (parent.CannotBornTimes >= 3)
                {
                    parent.ReproductionProgress = 0;
                    parent.State = UnitState.Wander;
                    parent.Mass -= parent.Species.ReproductionMass;
                    parent.CannotBornTimes = 0;
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
                            if (unit.Species.EatList.Contains(item.Unit.Species))
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
                        if (target.X < unit.Cell.X)
                        {
                            direction = direction + Math.PI;
                        }
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
                    double attack = unit.Species.EatSpeed - target.Unit.Species.Defence;
                    if (attack > 0)
                    {
                        double damage = Math.Min(target.Unit.Mass, attack);
                        target.Unit.Mass -= attack;
                        unit.Mass += damage;
                    }
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
                dead.Cell.Unit = null;
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

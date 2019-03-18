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

        private void UnitsDo()
        {
            Random rand = new Random();

            foreach (var unit in _units)
            {
                if (unit.State == UnitState.Moving)
                {
                    double direction = rand.NextDouble() * 360;
                    double dx = unit.Species.Speed * Math.Cos(direction);
                    double dy = unit.Species.Speed * Math.Sin(direction);

                    unit.LocalX += dx;
                    unit.LocalY += dy;
                }
                else if (unit.State == UnitState.Reproduction)
                {

                }
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
                if (unit.LocalY > 0)
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
                if (unit.Cell.Y + dy > -_mapHeight)
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
            MoveUnits();
        }

        public void AddUnit(Unit unit)
        {
            _units.Add(unit);
        }
    }
}

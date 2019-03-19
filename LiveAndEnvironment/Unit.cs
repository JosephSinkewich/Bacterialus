using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveAndEnvironment
{
    public class Unit
    {
        public double LocalX { get; set; }
        public double LocalY { get; set; }// coords inside cell
        public Cell Cell { get; set; }

        public Species Species { get; set; }
        public double Mass { get; set; }
        
        public UnitState State { get; set; }

        public double ReproductionProgress { get; set; }
        
        public int CannotBornTimes { get; set; }

        public bool IsLive
        {
            get
            {
                if (Mass <= 0)
                {
                    return false;
                }
                return true;
            }
        }

        public Unit(Species species, Cell cell)
        {
            LocalX = 0.5;
            LocalY = 0.5;

            Cell = cell;
            Cell.Unit = this;

            Species = species;
            Species.IncrementLiveBeing();

            Mass = Species.ReproductionMass / 2.0;

            State = UnitState.Wander;

            CannotBornTimes = 0;
        }

        public void Grow()
        {
            Mass += Species.GrowSpeed;
        }

        public void EnvironmentDamage()
        {
            if (Cell.Environment != null)
            {
                double resultInfluence = Cell.Environment.Concentration;
                resultInfluence *= Species.Adaptations[Cell.Environment.Type].Influence;
                Mass += resultInfluence;
            }
        }
    }
}

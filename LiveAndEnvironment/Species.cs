using System;
using System.Collections.Generic;

namespace LiveAndEnvironment
{
    public class Species
    {
        public string Name { get; private set; }

        public Dictionary<Environment, Adaptation> Adaptations { get; set; }

        public double Speed { get; set; }

        public List<Species> EatList { get; set; }
        public double EatSpeed { get; set; }
        public double Defence { get; set; }
        public double GrowSpeed { get; set; }

        public double ReproductionMass { get; set; }
        public double ReproductionSpeed { get; set; }

        public Species(string name)
        {
            Name = name;
            Adaptations = new Dictionary<Environment, Adaptation>();

            Speed = 0;

            EatList = new List<Species>();
            Defence = 0;
            GrowSpeed = 0;

            ReproductionMass = 0;
            ReproductionSpeed = 0;
        }
    }
}

using System;
using System.Collections.Generic;

namespace LiveAndEnvironment
{
    public class Species
    {
        public string Name { get; set; }

        public Dictionary<Environment, Adaptation> Adaptations { get; set; }

        public double Speed { get; set; }

        public HashSet<Species> EatList { get; set; }
        public double EatSpeed { get; set; }
        public double Defence { get; set; }
        public double GrowSpeed { get; set; }

        public double ReproductionMass { get; set; }
        public double ReproductionSpeed { get; set; }

        public HashSet<BehaviorPattern> Behavior { get; set; }

        public HashSet<Species> DangerList { get; set; }
        public HashSet<Environment> FavorEnvironments { get; set; }

        public double SensorRadius { get; set; }

        public Species(string name)
        {
            Name = name;
            Adaptations = new Dictionary<Environment, Adaptation>();

            Speed = 0;

            EatList = new HashSet<Species>();
            Defence = 0;
            GrowSpeed = 0;

            ReproductionMass = 0;
            ReproductionSpeed = 0;

            Behavior = new HashSet<BehaviorPattern>();

            DangerList = new HashSet<Species>();
            FavorEnvironments = new HashSet<Environment>();
            SensorRadius = 0;
        }
    }
}

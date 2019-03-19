using System;
using System.Collections.Generic;

namespace LiveAndEnvironment
{
    public class Species
    {
        public string Name { get; set; }

        public Dictionary<EnvironmentType, Adaptation> Adaptations { get; set; }

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

        private int _countLiveBeings;

        #region(constructors)
        public Species(string name)
        {
            Name = name;
            Adaptations = new Dictionary<EnvironmentType, Adaptation>();

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

            _countLiveBeings = 0;
            AllLiveSpecies.Add(this);
        }

        public Species(Species parent)
        {
            Name = parent.Name + "descendant";
            Adaptations = new Dictionary<EnvironmentType, Adaptation>(parent.Adaptations);
            
            Speed = parent.Speed;

            EatList = new HashSet<Species>(parent.EatList);
            Defence = parent.Defence;
            GrowSpeed = parent.GrowSpeed;

            ReproductionMass = parent.ReproductionMass;
            ReproductionSpeed = parent.ReproductionSpeed;

            Behavior = new HashSet<BehaviorPattern>(parent.Behavior);

            DangerList = new HashSet<Species>(parent.DangerList);
            FavorEnvironments = new HashSet<Environment>(parent.FavorEnvironments);
            SensorRadius = parent.SensorRadius;

            _countLiveBeings = 0;
            AllLiveSpecies.Add(this);
        }
        #endregion

        public void AddAdaptation(Adaptation adaptation)
        {
            if (Adaptations.ContainsKey(adaptation.Environment))
            {
                Adaptations[adaptation.Environment].Influence += adaptation.Influence;
            }
            else
            {
                Adaptations.Add(adaptation.Environment, adaptation);
            }
        }


        #region(AllLiveSpecies)
        public void IncrementLiveBeing()
        {
            _countLiveBeings++;
        }

        public void CheckExtinction()
        {
            if (_countLiveBeings <= 0)
            {
                AllLiveSpecies.Remove(this);
            }
        }

        public static List<Species> AllLiveSpecies { get; set; } = new List<Species>();
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LiveAndEnvironment
{
    public class Species
    {
        public string Name { get; set; }
        public FoodType FoodType { get; set; }
        public Species Parent { get; private set; }

        public Dictionary<EnvironmentType, Adaptation> Adaptations { get; set; }

        public double Speed { get; set; }

        public HashSet<FoodType> FoodList { get; set; }
        public double EatSpeed { get; set; }
        public double Defense { get; set; }
        public double GrowSpeed { get; set; }

        public double ReproductionMass { get; set; }
        public double ReproductionSpeed { get; set; }

        public HashSet<BehaviorPattern> Behavior { get; set; }

        public HashSet<Species> DangerList { get; set; }
        public HashSet<Environment> FavorEnvironments { get; set; }

        public double SensorRadius { get; set; }

        private int _countLiveBeings;
        public int Population
        {
            get
            {
                return _countLiveBeings;
            }
        }

        #region(Evolve constants)
        const double INFLUENCE_MAX_EVOLVE = 0.1;
        const double SPEED_MAX_EVOLVE = 0.1;
        const double REPRODUCTION_SPEED_MAX_EVOLVE = 0.4;
        const double EAT_SPEED_MAX_EVOLVE = 0.1;
        const double DEFENSE_MAX_EVOLVE = 0.05;
        const double REPRODUCTION_MASS_MAX_EVOLVE = 0.2;
        const double SENSOR_MAX_EVOLVE = 0.2;
        const double GROW_SPEED_MAX_EVOLVE = 0.002;
        #endregion

        #region(constructors)
        public Species(string name, FoodType foodType)
        {
            Name = name;
            FoodType = foodType;
            Parent = null;

            Adaptations = new Dictionary<EnvironmentType, Adaptation>();

            Speed = 0;

            FoodList = new HashSet<FoodType>();
            Defense = 0;
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
            Name = parent.Name;
            FoodType = parent.FoodType;
            Parent = parent;

            Adaptations = new Dictionary<EnvironmentType, Adaptation>(parent.Adaptations);

            Speed = parent.Speed;

            FoodList = new HashSet<FoodType>(parent.FoodList);
            EatSpeed = parent.EatSpeed;
            Defense = parent.Defense;
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

        private string EvolveName(string name, bool addSomething)
        {
            Random rand = new Random();
            if (addSomething || name.Length == 1)
            {
                char newChar = '0';
                if (rand.Next(2) == 0)
                {
                    newChar = Convert.ToChar(rand.Next(65, 91));
                }
                else
                {
                    newChar = Convert.ToChar(rand.Next(97, 123));
                }
                return name + newChar;
            }
            else
            {
                return name.Remove(rand.Next(name.Length), 1);
            }
        }

        public Species Evolve()
        {
            Random random = new Random();

            bool addSomething = Convert.ToBoolean(random.Next(2));

            int propertyNumber = random.Next(10);

            Species descendant = new Species(this);
            descendant.Name = EvolveName(descendant.Name,  addSomething);

            if (propertyNumber == 0)//Adaptations
            {
                if (EnvironmentType.AllEnvironments.Count > 0)
                {
                    EnvironmentType environmentType =
                        EnvironmentType.AllEnvironments[random.Next(EnvironmentType.AllEnvironments.Count)];
                    double influence = random.NextDouble() * INFLUENCE_MAX_EVOLVE;
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
                    descendant.Speed += random.NextDouble() * SPEED_MAX_EVOLVE;
                }
                else
                {
                    descendant.Speed -= random.NextDouble() * SPEED_MAX_EVOLVE;
                }
            }
            else if (propertyNumber == 2)//EatList
            {
                if (addSomething)
                {
                    FoodType food = null;
                    food = FoodType.AllFoodTypes[random.Next(FoodType.AllFoodTypes.Count)];
                    descendant.FoodList.Add(food);
                }
                else
                {
                    FoodType foodToDelete = null;
                    foreach (var item in descendant.FoodList)
                    {
                        if (random.Next(descendant.FoodList.Count) == 0)
                        {
                            foodToDelete = item;
                            break;
                        }
                    }
                    descendant.FoodList.Remove(foodToDelete);
                }
            }
            else if (propertyNumber == 3)//ReproductionSpeed
            {
                if (addSomething)
                {
                    descendant.ReproductionSpeed += random.NextDouble() * REPRODUCTION_SPEED_MAX_EVOLVE;
                }
                else
                {
                    descendant.ReproductionSpeed -= random.NextDouble() * REPRODUCTION_SPEED_MAX_EVOLVE;
                }
            }
            else if (propertyNumber == 4)//Mass
            {
                if (addSomething)
                {
                    descendant.ReproductionMass += random.NextDouble() * REPRODUCTION_MASS_MAX_EVOLVE;
                }
                else
                {
                    descendant.ReproductionMass -= random.NextDouble() * REPRODUCTION_MASS_MAX_EVOLVE;
                }
            }
            else if (propertyNumber == 5)//SensorRadius
            {
                if (addSomething)
                {
                    descendant.SensorRadius += random.NextDouble() * SENSOR_MAX_EVOLVE;
                }
                else
                {
                    descendant.SensorRadius -= random.NextDouble() * SENSOR_MAX_EVOLVE;
                }
            }
            else if (propertyNumber == 6)//EatSpeed
            {
                if (addSomething)
                {
                    descendant.EatSpeed += random.NextDouble() * EAT_SPEED_MAX_EVOLVE;
                }
                else
                {
                    descendant.EatSpeed -= random.NextDouble() * EAT_SPEED_MAX_EVOLVE;
                }
            }
            else if (propertyNumber == 7)//ChangeFoodType
            {
                if (random.Next(FoodType.AllFoodTypes.Count * 3) != 0)
                {
                    int foodTypeNumber = random.Next(FoodType.AllFoodTypes.Count);
                    descendant.FoodType = FoodType.AllFoodTypes[foodTypeNumber];
                }
                else
                {
                    descendant.FoodType = new FoodType(EvolveName(descendant.FoodType.Name, Convert.ToBoolean(random.Next(2))));
                }
            }
            else if (propertyNumber == 8)//Defense
            {
                if (addSomething)
                {
                    descendant.Defense += random.NextDouble() * DEFENSE_MAX_EVOLVE;
                }
                else
                {
                    descendant.Defense -= random.NextDouble() * DEFENSE_MAX_EVOLVE;
                }
            }
            else if (propertyNumber == 9)//GrowSpeed
            {
                if (addSomething)
                {
                    descendant.GrowSpeed += random.NextDouble() * GROW_SPEED_MAX_EVOLVE;
                }
                else
                {
                    descendant.GrowSpeed -= random.NextDouble() * GROW_SPEED_MAX_EVOLVE;
                }
            }

            return descendant;
        }

        #region(AllLiveSpecies)
        public void IncrementLiveBeing()
        {
            _countLiveBeings++;
        }

        public void DecrementLiveBeing()
        {
            _countLiveBeings--;
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

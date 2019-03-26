using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveAndEnvironment
{
    public class FoodType
    {
        public string Name { get; set; }

        public FoodType(string name)
        {
            Name = name;
            AllFoodTypes.Add(this);
        }

        public override string ToString()
        {
            return Name;
        }

        public static List<FoodType> AllFoodTypes { get; set; } = new List<FoodType>();
    }
}

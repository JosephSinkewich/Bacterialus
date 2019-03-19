using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveAndEnvironment
{
    public class EnvironmentType
    {
        public string Name { get; set; }

        public EnvironmentType(string name)
        {
            Name = name;
            AllEnvironments.Add(this);
        }

        public static List<EnvironmentType> AllEnvironments { get; set; } = new List<EnvironmentType>();
    }
}

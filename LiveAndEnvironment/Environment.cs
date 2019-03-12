using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveAndEnvironment
{
    public class Environment
    {
        public double Danger { get; set; }
        public EnvironmentType Type { get; private set; }

        public Environment(double danger, EnvironmentType type)
        {
            Danger = danger;
            Type = type;
        }
    }
}

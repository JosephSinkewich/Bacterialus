using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveAndEnvironment
{
    public class Adaptation
    {
        public EnvironmentType Environment { get; private set; }
        public double Resist { get; private set; }

        public Adaptation(EnvironmentType environment, double resist)
        {
            Environment = environment;
            Resist = resist;
        }
    }
}

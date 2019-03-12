using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveAndEnvironment
{
    public class Cell
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Environment Environment { get; private set; }
        public Unit Unit { get; set; }

        public Cell(Environment environment, int x, int y)
        {
            X = x;
            Y = y;
            Environment = environment;
            Unit = null;
        }
    }
}

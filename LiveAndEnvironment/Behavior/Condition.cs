using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveAndEnvironment
{
    public abstract class Condition
    {
        public bool Prepared { get; protected set; }

        public virtual bool GetCaptionResult()
        {
            if (Prepared == false)
            {
                throw new Exception("Condition most be prepared!");
            }
            return true;
        }
    }
}

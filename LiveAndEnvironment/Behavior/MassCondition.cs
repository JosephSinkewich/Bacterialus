using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveAndEnvironment
{
    public class MassCondition : Condition
    {
        public double Mass { get; private set; }
        public double ComprassionMass { get; private set; }
        public ComprassionSigns ComprassionSign { get; private set; }

        public MassCondition(double comprassionMass, ComprassionSigns sign)
        {
            Mass = 0;
            ComprassionMass = comprassionMass;
            ComprassionSign = sign;

            Prepared = false;
        }

        public void PrepareCondition(double mass)
        {
            Mass = mass;

            Prepared = true;
        }

        public override bool GetCaptionResult()
        {
            base.GetCaptionResult();
            if (ComprassionSign == ComprassionSigns.Less)
            {
                return Mass < ComprassionMass;
            }
            else
            {
                return Mass > ComprassionMass;
            }
        }
    }
}

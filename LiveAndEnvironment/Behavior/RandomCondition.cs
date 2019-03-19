using System;

namespace LiveAndEnvironment
{
    public class RandomCondition : Condition
    {
        public int Chance { get; private set; }
        public int RandomValue { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chance">most be from 1 to 100</param>
        public RandomCondition(int chance)
        {
            Chance = chance;
        }

        public void PrepareCondition()
        {
            Random random = new Random();
            RandomValue = random.Next(100);
        }

        public override bool GetCaptionResult()
        {
            base.GetCaptionResult();
            return RandomValue < Chance;
        }
    }
}

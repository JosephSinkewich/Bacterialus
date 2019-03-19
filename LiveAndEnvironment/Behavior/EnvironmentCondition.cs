using System;

namespace LiveAndEnvironment
{
    public class EnvironmentCondition : Condition
    {
        public EnvironmentType Environment { get; private set; }
        public EnvironmentType ConditionEnvironment { get; private set; }

        public EnvironmentCondition(EnvironmentType conditionEnvironment)
        {
            Environment = null;
            ConditionEnvironment = conditionEnvironment;

            Prepared = false;
        }

        public void PrepareCondition(EnvironmentType environment)
        {
            Environment = environment;

            Prepared = true;
        }

        public override bool GetCaptionResult()
        {
            base.GetCaptionResult();
            return Environment == ConditionEnvironment;
        }
    }
}

namespace LiveAndEnvironment
{
    public class BehaviorPattern
    {
        public Condition Condition { get; private set; }
        public UnitState ResultState { get; private set; }

        public BehaviorPattern(Condition condition, UnitState resultState)
        {
            Condition = condition;
            ResultState = resultState;
        }

        public bool CheckCondition(out UnitState resultState)
        {
            bool result = false;
            resultState = UnitState.Stay;
            if (Condition.GetCaptionResult())
            {
                result = true;
                resultState = ResultState;
            }
            return result;
        }
    }
}

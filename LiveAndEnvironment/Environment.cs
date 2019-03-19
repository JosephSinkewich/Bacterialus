namespace LiveAndEnvironment
{
    public class Environment
    {
        public double Concentration { get; set; }
        public EnvironmentType Type { get; private set; }

        public Environment(double concentration, EnvironmentType type)
        {
            Concentration = concentration;
            Type = type;
        }
    }
}

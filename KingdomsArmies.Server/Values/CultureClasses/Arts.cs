namespace KingdomsArmies.Server.Values.CultureClasses
{
    public class Arts : Culture
    {
        public double Personal { get; private set; }
        public double Commercial { get; private set; }
        public double Political { get; private set; }
        public Arts(bool isRaw, double popularity, int specialismA, int specialismB, int specialismC) : base(popularity, specialismA, specialismB, specialismC)
        {
            if (isRaw)
            {
                (Personal, Commercial, Political) = ((double)SpecialismA, (double)SpecialismB, (double)SpecialismC);
            }
            else
            {
                (Personal, Commercial, Political) = UpdateSpecialisms();
            }
        }

        



    }
}

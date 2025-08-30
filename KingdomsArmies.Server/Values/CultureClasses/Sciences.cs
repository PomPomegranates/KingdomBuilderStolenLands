namespace KingdomsArmies.Server.Values.CultureClasses
{
    public class Sciences : Culture
    {
        public double History { get; private set; }
        public double Arcana { get; private set; }
        public double Alchemy { get; private set; }


        public Sciences(bool isRaw, double popularity, int starterHistory, int starterArcana, int starterAlchemy) : base(popularity, starterHistory, starterArcana, starterAlchemy)
        {
            if (isRaw)
            {

                (History, Arcana, Alchemy) = ((double)SpecialismA, (double)SpecialismB, (double)SpecialismC);
            }
            else
            {
                (History, Arcana, Alchemy) = UpdateSpecialisms();
            }

        }
        


    }
}

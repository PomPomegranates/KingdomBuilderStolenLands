using KingdomsArmies.Server.Values;
using KingdomsArmies.Server.Values.CultureClasses;

namespace KingdomsArmies.Server
{
    public class Population
    {
        public Population(Sciences? rawSciences, Arts? rawArts, LivingStandard livingStandard)
        {
            RawSciences = rawSciences;
            RawArts = rawArts;
            LivingStandard = livingStandard;
        }

        public Sciences? RawSciences { get; set; }
        public Arts? RawArts { get; set; }
        public LivingStandard LivingStandard { get; set; }




    }
}

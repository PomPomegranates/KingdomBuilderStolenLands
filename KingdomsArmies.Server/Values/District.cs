using KingdomsArmies.Server.Values.CultureClasses;

namespace KingdomsArmies.Server.Values
{
    public class District
    {
        public Arts Arts { get; set; }
        public Sciences Sciences { get; set; }
        public Food Food { get; set; }
        public int FoodSupply { get; set; }
        public List<Population> Population { get; set; }


    }
}

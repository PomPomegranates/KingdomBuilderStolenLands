namespace KingdomsArmies.Server.Values
{
    public class Food
    {
        
        public int Meat { get; set; }
        public int Fish { get; set;  }
        public int Crops { get; set; }


        public void GoFishing(Region region, int value)
        {
            //will want a god domain/relevant domains
            Fish += 1;
        }
        public void GoFarming(int value)
        {
            Crops -= 12;
            Meat += 15;
        }

    }
}

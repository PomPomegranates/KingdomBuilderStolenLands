namespace KingdomsArmies.Server.Values
{
    public class Region
    {
        public District[] Districts { get; set; }
        private int _count { get; set; } = 0;
        private int _space { get; set; }

        public Region(int space)
        {
            _space = space;
            Districts = new District[_space];

        }

        public bool AddDistrict(District district)
        {
            if(_count > _space)
            {
                return false;
            }
            Districts[_count] = district;
            _count += 1;
            return true;
        }
    }
}

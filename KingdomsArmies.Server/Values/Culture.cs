using System.Diagnostics;

namespace KingdomsArmies.Server.Values
{
    public abstract class Culture
    {
        public double Popularity { get; set; }
        protected int SpecialismA { get; set; }
        protected int SpecialismB { get; set; }
        protected int SpecialismC { get; set; }


        public Culture (double popularity, int specialismA, int specialismB, int specialismC)
        {
            SpecialismA = specialismA;
            SpecialismB = specialismB;
            SpecialismC = specialismC;
            Popularity = popularity;
        }
        



        public void AddPopOpinion(int val1, int val2, int val3)
        {
            SpecialismA += val1;
            SpecialismB += val2;
            SpecialismC += val3;
        }


        public (double, double, double) UpdateSpecialisms()
        {
            double specialismSum = SpecialismA + SpecialismB + SpecialismC;
            if (specialismSum == 0)
            {
                double third = 1 / (double)3;
                return (third, third, third);
            }
            double val1 = SpecialismA / specialismSum;
            double val2 = SpecialismB / specialismSum;
            double val3 = SpecialismC / specialismSum;


            return (val1, val2, val3);
        }

    }
}

namespace KingdomsArmies.Server.Values
{
    public static class Wealth 
    {
        public static LivingStandard MeanAverage(List<Population> population)
        {
            int total = 0;
            LivingStandard average = (LivingStandard)0;
            foreach (Population pop in population)
            {
                LivingStandard queEs = pop.LivingStandard;
                total += (int)pop.LivingStandard;
            }
            float averageInt = total / population.Count;
            foreach (int i in Enum.GetValues<LivingStandard>())
            {
                if ((int)(LivingStandard)i > averageInt)
                {
                    break;
                }
                average = (LivingStandard)i;
            }
            return average;
        }
        //public static LivingStandard MeanMode(List<Population> population)
        //{

        //    return;
        //}
        //public static LivingStandard MeanMedian(List<Population> population)
        //{

        //    return;
        //}


    }
}

using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            int kol = 0;
            if ((initialPopulation != 0 || currentPopulation != 0) && (initialPopulation != currentPopulation))
            {
                while (initialPopulation < currentPopulation)
                {
                    percent = (initialPopulation * 5) / 100;
                    initialPopulation = initialPopulation + visitors + (int)percent;
                    kol++;
                }
                return kol;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
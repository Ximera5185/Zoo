using System;

namespace Zoo
{
    internal class UserUtils
    {
        private static Random s_random = new Random();

        public static int GetRandomNumber(int minValue, int maxValue)
        {
            return s_random.Next(minValue, maxValue);
        }

        public static int GetRandomNumber( int maxValue)
        {
            return s_random.Next( maxValue);
        }
    }
}
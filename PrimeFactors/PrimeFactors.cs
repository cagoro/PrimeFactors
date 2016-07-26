using System.Collections.Generic;

namespace Primes
{
    public class PrimeFactors
    {
        public static List<int> Generate(int number)
        {
            var factors = new List<int>();
            int divisor = 2;
            while (number != 1)
            {
                while (number % divisor == 0)
                {
                    factors.Add(divisor);
                    number = number / divisor;
                }
                divisor++;
            }
            return factors;
        }
    }
}

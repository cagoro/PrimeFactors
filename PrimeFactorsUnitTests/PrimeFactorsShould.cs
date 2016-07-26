using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Primes;

namespace PrimeFactorsUnitTests
{
    [TestFixture]
    public class PrimeFactorsShould
    {
        private static Object[] CreateExpectedPrimeFactorsFor(int number, params int[] factors)
        {
            return new object[] {number, factors.ToList()};
        }

        private static readonly object[] FACTORS =
        {
            CreateExpectedPrimeFactorsFor(2, 2),
            CreateExpectedPrimeFactorsFor(3, 3),
            CreateExpectedPrimeFactorsFor(4, 2, 2),
            CreateExpectedPrimeFactorsFor(6, 2, 3),
            CreateExpectedPrimeFactorsFor(8, 2, 2, 2),
            CreateExpectedPrimeFactorsFor(1296, 2, 2, 2, 2, 3, 3, 3, 3),
            CreateExpectedPrimeFactorsFor(30, 2, 3, 5),
            CreateExpectedPrimeFactorsFor(53130, 2, 3, 5, 7, 11, 23)
        };

        [Test, TestCaseSource("FACTORS")]
        public void return_the_prime_factors_of_the_passed_number(int number, List<int> expectedFactors)
        {
            List<int> factors = PrimeFactors.Generate(number);
            Assert.AreEqual(factors, expectedFactors);
        }        
    }
}

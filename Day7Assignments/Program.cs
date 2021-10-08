using System;

namespace Day7Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 7 Assignment");
            PrimeFactorization obj1 = new PrimeFactorization();
            obj1.PrimeFactors();
            SecondLargestAndSmallest obj2 = new SecondLargestAndSmallest();
            obj2.Second();
        }
    }
}

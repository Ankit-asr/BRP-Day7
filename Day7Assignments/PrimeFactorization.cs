using System;
using System.Collections.Generic;
using System.Text;

namespace Day7Assignments
{
    class PrimeFactorization
    {
        public void PrimeFactors()
        {
            int number, i;
            Console.WriteLine("Enter Number whose Prime factors are to be calculated ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Prime Factors of " + number + " are : 1");
            for (i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    int check = 0;
                    for (int j = 1; j <= i; j++)
                        if (i % j == 0)
                            check++;
                    if (check == 2)
                        Console.Write("," + i);
                }
            }
            Console.WriteLine(" ");
        }
    }
}
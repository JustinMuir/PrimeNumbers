using System;

namespace PrimeNumbers
{
    class Program
    {

        public static void Main(String[] args)
        {
            int count = 1;
            int max = 100;

            Console.WriteLine("First 100 Prime Numbers: ");

            for (int i = 2; count < max; i++)
            {
                //check if current number is prime
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                    count++;
                }

            }
            //Console.WriteLine();
            
            Console.ReadKey();
        }

        static bool IsPrime(int numToCheck)
        {

            //Run a loop from 2 to numToCheck / 2.
            for (int i = 2; i <= numToCheck / 2; i++)
            {
                // if the number is divisible by i, then its not a prime number.
                if (numToCheck % i == 0)
                    return false;
            }
            return true;
        }

    }
}

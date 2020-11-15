using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberSet
{
    class Program
    {
        static bool PrimeNumberSet(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");

            int val = int.Parse(Console.ReadLine());

            Console.WriteLine("The prime numbers' set is: ");

            for (int i = 0; i < val; i++)
            {
                if (PrimeNumberSet(i))
                {
                    Console.WriteLine($"\t\t\t\t{i}\n");
                }
            }
        }
    }
}

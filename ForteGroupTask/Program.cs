using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForteGroupTask
{
    class Program
    {
        static void Main(string[] args)
        {           
            while (true)
            {
                int n;
                string c = Console.ReadLine();
                if (int.TryParse(c, out n))
                {
                    n = int.Parse(c);
                    if ((IsMersenne(n) == true) & (IsPrime(n)==true))
                        Console.WriteLine("It is Mersenne prime number");
                    else if (IsPrime(n) == true)
                        Console.WriteLine("It is a regular prime number son");
                    else
                        Console.WriteLine("It is not a prime number");
                }
                else
                    Console.WriteLine("Invalid number");

                if (c == "quit")
                {
                    return;
                }
                break;
              
            }
            Console.ReadLine();
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) { return false; }

            int counter = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0) { counter++; }
                if (counter > 2) { return false; }
            }

            return true;
        }
        static bool IsMersenne(int n)
        {
            int i = 2;
            while (((1 << i) - 1) <= n) i++;

            if (((1 << i - 1) - 1) == n || ((1 << i - 1) + 1) == n)
                return true;
            return false;
        }
    }
}

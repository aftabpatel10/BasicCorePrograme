using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Factors Problem");
            Console.WriteLine("Enter a value ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i*i<= n; i++)
            {
                while (n % i == 0)
                {
                    n = n / i;
                    Console.WriteLine(i + "");
                }

            }
            if (n != 1)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}

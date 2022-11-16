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
            Console.WriteLine("Welcome To Harmonic Number Problem");
            Console.WriteLine("Enter a value ");
            Random random = new Random();
            double n= Convert.ToDouble(Console.ReadLine());
            double result = 1;
            for (int i = 1; i < n; i++)
            {
                result += (float)1/i;
            }
            Console.WriteLine("Harmonic Value is :" +result);
            Console.ReadLine();
        }
    }
}

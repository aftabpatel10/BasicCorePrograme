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
            Console.WriteLine("Welcome To Quotient And Remainder Problem");
            Console.WriteLine("Enter a value of divident ");
            Console.WriteLine("Enter a value of devisor");
            int divident = Convert.ToInt32(Console.ReadLine());
            int devisor = Convert.ToInt32(Console.ReadLine());
            int Quotient = divident / devisor;
            int Remainder = divident % devisor;
            Console.WriteLine("Remainder :" + Remainder);
            Console.WriteLine("Quotient :" +Quotient);
            Console.ReadLine();
        }
    }
}

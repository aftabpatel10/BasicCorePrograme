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
            Console.WriteLine("Welcome To Swap the Numbers Problem");
            Console.WriteLine("Enter a value of Number a ");
            Console.WriteLine("Enter a value of Number b");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int Swap;
            Swap = a;
                a = b;
                b = Swap;
            Console.WriteLine("Number a is :" +a);
            Console.WriteLine("Number b is :" +b);
            Console.ReadLine();
        }
    }
}

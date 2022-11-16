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
            Console.WriteLine("Welcome To Coin Flip Programe");
            Console.WriteLine("Enter No.of Times Coin to be Flip");
            Random random = new Random();
            int n = Convert.ToInt32(Console.ReadLine());
            int Head = 0, Tail = 0;
            for (int i = 0; i < n; i++)
            {
                Double CoinFlip = random.NextDouble();
                if (CoinFlip < 0.5)
                {
                    Tail++;
                }
                else
                {
                    Head++;
                }
            }
            Double Headpercentage = Head * 100 / n;
            Console.WriteLine($"Head Times : {Headpercentage}%");
            Double Tailpercentage = Tail * 100 / n;
            Console.WriteLine($"Tail Times: {Tailpercentage}%");
            Console.ReadLine();

        }
    }
}

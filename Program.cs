using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("A number times itself is very POWERFUL!");
                Console.WriteLine("###########");
                Console.Write("Enter a Number to start : ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Enter the number of POWER: ");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("###########");


                long result = pow(x, y);

                Console.WriteLine("The number {0}^{1} = {2} is the result", x, y, result);
                Console.ReadKey();
                
            }
        }
            public static long pow(int x, int y)
        {
            long z = 1;
            for (long i=1; i<=y; i++)
            {
                z = z * x;
            }
            return z;
                
        }
    }
}

            

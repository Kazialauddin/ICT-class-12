using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a =");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("b =");
            decimal b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("c =");
            decimal c = decimal.Parse(Console.ReadLine());
            Console.WriteLine("a{0} b={1} c={2}",a,b,c);

            if (a == b)
            {
                Console.WriteLine("a==b");
            }
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("a Is Greater then all");
                }
                else
                {
                    Console.WriteLine("c Is Greater than all");
                }
               
            }
            else
            {
                if (b > c)
                {

                    Console.WriteLine("b Is Greater then all");
                }
                else
                {
                    Console.WriteLine("c Is Greater than all");
                }

            }

            Console.ReadKey();
        }
    }
}

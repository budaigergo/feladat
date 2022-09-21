using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adj meg kettő egész számot!:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());eadLine());

            if (a > b)
            {
                Console.WriteLine("A nagyobb szám:{0}", a);
            }
            else { Console.WriteLine("A nagyobb szám:{0}", b); }

            Console.ReadLine();
        }
    }
}

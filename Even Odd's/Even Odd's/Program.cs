using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Odd_s
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = Convert.ToChar(Console.ReadLine());
            long p = Convert.ToChar(Console.ReadLine());
            n = (n + 1) / 2;
            if (p > n)
            {
                Console.WriteLine(2 * (p - n));
            }
            else
            {
                Console.WriteLine(2 *p - 1);
            }

        }
    }
}

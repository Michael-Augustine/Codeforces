using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wrong_Subtraction_16._08._21
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] MY = input.Split();
            int n = Convert.ToInt32(MY[0]);
            int k = Convert.ToInt32(MY[1]);
            for (int i = 0; i < k; i++)
            {
                if (n % 10 == 0)
                {
                    n=n/10;                    
                }
                else
                {
                    n--;
                }                
            }
            Console.WriteLine(n);
        }
    }
}

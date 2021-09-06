using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Pink = Console.ReadLine().Split(' ');
            int A1 = Convert.ToInt32(Pink[0]);
            int A2 = Convert.ToInt32(Pink[1]);
            int A3 = Convert.ToInt32(Pink[2]);
            int result;
            result = A1 + A2 + A3;
            if (result<22)
            {
                Console.WriteLine("Win");
            }
            else 
            {
                Console.WriteLine("Bust");
            }
            
        }
    }
}

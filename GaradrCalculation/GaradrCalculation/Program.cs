using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaradrCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Student Name");
            String S = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter The 3 Subject Mark's");
            int M1 = Convert.ToInt32(Console.ReadLine());
            int M2 = Convert.ToInt32(Console.ReadLine());
            int M3 = Convert.ToInt32(Console.ReadLine());
            int TO = M1 + M2 + M3;
            if (TO < 100)
            {
                Console.WriteLine("Your Grade Is Low");
            }
            else if (TO < 200)
            {
                Console.WriteLine("Your Grede Is Average");
            }
            else if (TO < 300)
            {
                Console.WriteLine("Your Gread Is Highest");
            }
            Console.ReadLine();
        }
    }
}

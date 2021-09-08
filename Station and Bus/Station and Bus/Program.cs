using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poor
{
    class Program
    {
        static void Main(string[] args)
        {
            string Poo = Console.ReadLine();
            int A =Poo[0];
            int B =Poo[1];
            int C =Poo[2];
            if (A == B && B == C && C == A)
            {
                Console.WriteLine("No");
            }
            else if (A == B || B == C || C == A)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadLine();

        }
    }
}

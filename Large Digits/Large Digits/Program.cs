using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Large_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] A = Console.ReadLine().Split(' ');
            string[] B = Console.ReadLine().Split(' ');

            int x = Convert.ToInt32(A[0]);
            int y = Convert.ToInt32(A[1]);
            int z = Convert.ToInt32(A[2]);

            int a = Convert.ToInt32(B[0]);
            int b = Convert.ToInt32(B[1]);
            int c = Convert.ToInt32(B[2]);

            int P = x + y + z;
            int Q = a + b + c;

            if (P > Q)
            {
                Console.WriteLine(P);
            }
            else if (Q > P)
            {
                Console.WriteLine(Q);
            }
        }
    }
}

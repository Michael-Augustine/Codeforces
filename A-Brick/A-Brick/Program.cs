using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Brick
{
    class Program
    {
        static void Main(string[] args)
        {
            int N =Convert.ToInt32(Console.ReadLine());
            int W =Convert.ToInt32(Console.ReadLine());
            if (1 <= N && W <= 1000)
            {
                int B = N / W;
                Console.WriteLine(B);
            }
                       
        }
    }
}

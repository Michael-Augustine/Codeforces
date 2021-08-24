using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReLu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 0)
            {
                Console.WriteLine(x);
            }
            else if(x<0)
            {
                Console.WriteLine("0");
            }
            Console.ReadLine();
        }
    }
}

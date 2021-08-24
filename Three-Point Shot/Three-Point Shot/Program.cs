using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Point_Shot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] My = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(My[0]);//Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(My[1]);//Convert.ToInt32(Console.ReadLine());
            int Smalest = x;
            if (y < Smalest)
            {
                Smalest = y;
            }
            int largest =x;
            if(y>largest)
            {
                largest = y;
            }
            int p = Smalest + 3;
            if (p > largest)
            {
                Console.WriteLine("Yes");
            }
            else if (p < largest)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Drow");
            }
            Console.ReadLine();        
        }

    }
}

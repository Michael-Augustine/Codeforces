using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_ReDo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1st Program
            //Console.WriteLine("Enter the Size of an Array ");
            //int n=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter The K Value");
            //int k = Convert.ToInt32(Console.ReadLine());
            //int[] A = new int[n];

            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.WriteLine(k);
            //}
            //Console.ReadLine();
            #endregion
 
            #region 2dn Program
            Console.WriteLine("Enter The N Value");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int i;
            for (i = 0; i < a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine(a[i] + " ");
            Console.ReadLine();
            #endregion
        }
    }
}

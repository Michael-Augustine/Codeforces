using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From_3st_Program__3_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 Find out the Factors of N
            //Console.WriteLine("Enter The Number");
            //int N = Convert.ToInt32(Console.ReadLine());
            //for (int i = 2; i <= N; i++)
            //{
            //    if (N%i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine();
            #endregion 

            #region  2 Find If The Given number is Prime or Not
            //Console.WriteLine("Enter The Number");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //int Result = Check_Prime(Number);
            //if (Result == 0)
            //{
            //    Console.WriteLine(Number + " <--- It's Not Prime Number");
            //}
            //else
            //{
            //    Console.WriteLine(Number + " <--- It's A Prime Number");
            //}
            //Console.ReadLine();
            #endregion

            #region 3 Print all Prime Number's 1 to N

            //string pro;
            //do
            //{
            //Console.WriteLine("Enter The Number");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("-----> The Prime Number's Are <-----");
            //    for (int i = 1; i <= Number; i++)
            //    {
            //        int R = Check_Prime(i);
            //        if (R == 1)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //    Console.WriteLine("Do You Want To Continue Calculating 'Y' Or 'N' ");
            //    pro = Console.ReadLine();
            //    Console.Clear();
            //} while ((pro == "y") || (pro == "Y"));   
             
            #endregion   

            #region MyRegion
            
            #endregion
        }

        #region Prime
        public static int Check_Prime(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return 0;
                }
            }
            if (i == number)
            {
                return 1;
            }
            return 0;
        }

        #endregion
    }
}

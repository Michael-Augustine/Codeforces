using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_One
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.Number Of Eliment 
            
            //// Console.WriteLine("Enter The N Value");
            //Int32 N =GetInt("Enter The N value"); 
            ////Console.WriteLine("Enter The K Value");
            //Int32 K = GetInt("Enter The K Value"); 
            //int[] arr = new int[N];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = K;
            //    Console.Write(arr[i] + ", ");
            //}
            //Console.ReadLine();
            
            #endregion 
           
            #region 2.create an array of size N
            //Int32 N = GetInt("Enter The N value");
            //int[] arr = new int[N];
            //for (int i = 0; i <= arr.Length; i++)
            //{                
            //    Console.Write(i+ ", ");
            //}
            //Console.ReadLine();
            #endregion

            #region 3.Size N filled with random values between M and N
            //Int32 N = GetInt("Enter The N value");
            //Int32 X = GetInt("Enter the Starting Value for The rendome number Generartion");
            //Int32 W = GetInt("Enter The Ending Range");
            //Random Rand = new Random();           
            //int[] arr = new int[N];            
            //for (int i = 0; i < N; i++)
            //{
            //    int Ran = Rand.Next(X,W);
            //    Console.Write(Ran+" ,");
            //}
            //Console.ReadLine();
            #endregion



        }

        #region Geting Input From User Int,Char,Long,Double,String,
        
        public static int GetInt(string message)
        {
            Console.WriteLine("--- Geting Integer ---");
            Console.WriteLine(message+" :");
            int temp = Convert.ToInt32(Console.ReadLine());
            return temp;
        }

        public static char GetChar(string message)
        {
            Console.WriteLine("--- Geting Charecter ---");
            Console.WriteLine(message + " :");
            char temp = Convert.ToChar(Console.ReadLine());
            return temp;
        }

        public static long GetLong(string message)
        {
            Console.WriteLine("--- Geting Long ---");
            Console.WriteLine(message + " :");
            long temp = Convert.ToInt64(Console.ReadLine());
            return temp;
        }

        public static Double GetDouble(string message)
        {
            Console.WriteLine("--- Geting Double ---");
            Console.WriteLine(message + " :");
            Double temp = Convert.ToDouble(Console.ReadLine());
            return temp;
        }

        public static string GetString(string message)
        {
            Console.WriteLine("--- Geting String ---");
            Console.WriteLine(message + " :");
            String temp = Convert.ToString(Console.ReadLine());
            return temp;
        }
        #endregion 

        #region Random Number  
        public static int Random()
        {
            Random r = new Random();
            int genRand = r.Next(1,1000);
            return genRand;
        }
        //int Ra = Random();
        // Console.WriteLine("The Randome Number is "+Ra);
        // Console.ReadLine();
        #endregion
    }
}

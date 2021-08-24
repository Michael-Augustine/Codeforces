using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeaNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.Find out all factors of N
            //int N = GetInteger("Enter the number");
            //Console.WriteLine("The Factors of " + N + " is:");
            //for (int i = 2; i <= N; i++)
            //{
            //    if (N % i == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    Console.ReadLine();
            //}
            #endregion

            #region 2.Find if the given number is prime or not
            //int p = 0, num;
            //num = GetInteger("Enter the number");
            //for (int i = 2; i <= num / 2; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        p++;
            //        Console.WriteLine(num + ": is not Prime");
            //        break;
            //    }
            //}
            //if (p == 0)
            //{
            //    Console.WriteLine(num + ": is Prime");
            //}

            //int N = GetInteger("Enter the N Number");
            //if (isPrime(N))
            //{
            //    Console.WriteLine(N + " is Prime");
            //}
            //else
            //{
            //    Console.WriteLine(N + " is Not Prime");
            //}
            #endregion

            #region 3.Print all prime numbers from 1 to N
            //int N = GetInteger("Enter the number");
            //if (N >= 2)
            //{
            //    Console.Write(2+" "); 
            //}
            //for (int i = 3; i < N; i+=2)
            //{
            //    if (isPrime(i))
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            #endregion

            #region 4.Print the first “N” prime numbers starting from 2
            //int N=GetInteger("Enter the Number of Prime Number you want print");
            //int count=0;
            //for(int i=2;i<=N;i+=2)
            //{
            //    if(i==2)
            //    {
            //        Console.Write(2+" ");
            //        i++;
            //    }
            //    if((isPrime(i)||count<=N))
            //    {
            //        Console.Write(i+" ");
            //        count++;
            //    }
            //}
            #endregion
            #region 5.Find the number of prime numbers less than or equal to “N”
            //int N = GetInteger("Enter the number");
            //int c = 0;
            //for (int i = 2; i <= N; i++)
            //{
            //    int count = 1;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            count = 0;
            //            break;
            //        }
            //    }
            //    if (count != 0)
            //    {
            //        c = c + 1;
            //    }
            //}
            //if (c < N)
            //{
            //    Console.WriteLine("Lessthan");
            //    Console.WriteLine("The Number of prime Number is: " + c);
            //}
            //else if (c == N)
            //{
            //    Console.WriteLine("Equal");
            #endregion

        }
        public static int GetInteger(string message)
        {
            Console.WriteLine(message);
            int temp = Convert.ToInt32(Console.ReadLine());
            return temp;
        }
        public static bool isPrime(int N)
        {
            for (int i = 2; i < Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

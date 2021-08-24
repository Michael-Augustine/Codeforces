using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number_Finding
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Over All           
            #region 1. Find out all factors of N
            //Console.WriteLine("Enter the Number");
            //Int32 Num = Convert.ToInt32(Console.ReadLine());
            //Int32 N;
            //for (N = 1; N <= Num; N++)
            //{
            //    if (Num % N == 0)
            //    {
            //        Console.WriteLine(N);
            //    }
            //}
            //Console.ReadLine();
            #endregion

            #region 2. Find if the given number is prime or not
            //Console.WriteLine("Enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int result = Check_Prime(number);
            //if (result == 0)
            //{
            //    Console.WriteLine("{0} is not a prime number", number);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is  a prime number", number);
            //}
            //Console.Read();  
            #endregion

            #region 2
            //Console.WriteLine("Enter The Number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int a = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        a++; //a=a+1;
            //    }
            //}

            //if (a == 2)
            //{
            //    Console.WriteLine("is a Prime Number " + n);
            //}
            //else
            //{
            //    Console.WriteLine("Not a Prime Number " + n);
            //}
            //Console.ReadLine();            
            #endregion

            #region 2 Alternative
            //Console.WriteLine("Enter the Number");
            //Int32 a = Convert.ToInt32(Console.ReadLine());
            //if (a % 1 == 0 && a % a== 0)
            //{
            //    Console.WriteLine("Prime Number " + a);
            //}
            //else
            //{
            //    Console.WriteLine("Not A Prime Number " + a);
            //}
            //Console.ReadLine();
            #endregion 

            #region 2.Find if the given number is prime or not
            //int p=0,num;
            //num = GetInteger("Enter the number");
            //for (int i = 2; i <= num / 2; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        p++;
            //        Console.WriteLine(num+": is not Prime");
            //        break;
            //    }
            //}
            //if (p == 0)
            //{
            //    Console.WriteLine(num + ": is Prime");
            //}
            #endregion

            #region 3.Print all prime numbers from 1 to N
            //int N = GetInteger("Enter the number");
            //Console.WriteLine("Prime Numbers:");
            //for (int i = 2; i <= N; i++)
            //{
            //    int count = 0;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            count = 1;
            //            break;
            //        }

            //    }
            //    if (count == 0)
            //    {
            //        Console.Write(i + " ");
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
            //}
            #endregion
           
            #region 2 Is Prime 
            //Console.WriteLine("Enter the Number");
            //int N = Convert.ToInt32(Console.ReadLine());
            //bool R = IsPrimeV1(N);
            //Console.WriteLine("The Entered Number  " + N + " is " + R);
            //if (R == true)
            //{
            //    Console.WriteLine("It is Prime Number");
            //}
            //else
            //{
            //    Console.WriteLine("Not a Prime Number");
            //}
            //Console.ReadLine();
            #endregion

            #region 3 Print All Prime Numbers
            //Console.WriteLine("Enter the Number");
            //int N = Convert.ToInt32(Console.ReadLine());            
            //for (int i = 2; i <= N; i = i + 1)
            //{                
            //    if (IsPrime(i))
            //    {
            //       // if (N >= 2)
            //       // {
            //       //     Console.WriteLine("It's Prime Number 1 " + 2);
            //       //  }
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine();
            #endregion

            #region 4th Program

            //int num, i, ctr, stno, enno;
            //Console.Write("\n\n");
            //Console.Write("Find the prime numbers within a range of numbers:\n");
            //Console.Write("---------------------------------------------------");
            //Console.Write("\n\n");
            //Console.Write("Input starting number of range: ");
            //stno = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input ending number of range : ");
            //enno = Convert.ToInt32(Console.ReadLine());
            //Console.Write("The prime numbers between {0} and {1} are : \n", stno, enno);
            //for (num = stno; num <= enno; num++)
            //{
            //    ctr = 0;
            //    for (i = 2; i <= num / 2; i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            ctr++;
            //            break;
            //        }
            //    }
            //    if (ctr == 0 && num != 1)
            //        Console.Write("{0} ", num);
            //}
            //Console.Write("\n");
            //Console.ReadLine();

            #endregion

            #endregion

            #region 1. Find out all factors of N
            //Console.WriteLine("Enter the Number");
            //Int32 Num = Convert.ToInt32(Console.ReadLine());
            //Int32 N;
            //for (N = 1; N <= Num; N++)
            //{
            //    if (Num % N == 0)
            //    {
            //        Console.WriteLine(N);
            //    }
            //}
            //Console.ReadLine();
            #endregion

            #region 2.Program 
            Console.WriteLine("Enter The Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++; //a=a+1;
                }
            }

            if (a == 2)
            {
                Console.WriteLine("is a Prime Number " + n);
            }
            else
            {
                Console.WriteLine("Not a Prime Number " + n);
            }
            Console.ReadLine();            
            #endregion

            #region 3.Print all prime numbers from 1 to N
            //int N = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Prime Numbers:");
            //for (int i = 2; i <= N; i++)
            //{
            //    int count = 0;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            count = 1;
            //            break;
            //        }

            //    }
            //    if (count == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            //Console.ReadLine();
            #endregion

            #region 4th Program 
            //Console.WriteLine("Enter The Number");
            //int N = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Prime Numbers:");
            //for (int i = 2; i <= N; i++)
            //{
            //    int count = 0;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            count = 1;
            //            break;
            //        }

            //    }
            //    if (count == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            //Console.ReadLine();
            #endregion

            #region 5.Find the number of prime numbers less than or equal to “N”
            //Console.WriteLine("Enter The Number");
            //int N =Convert.ToInt32(Console.ReadLine());
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
            //}
            //Console.ReadLine();
            #endregion

        }

        #region OverAll        
        #region Check Prime Number or Not
        private static int Check_Prime(int number)
        {
            int i;
            for (i = 2; i <= number -1; i++)
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

        #region Is Prime
        public static bool IsPrime(int N)
        {
            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        //public static bool IsPrimeV1(int N)
        //{
        //    bool IsPrimeV1 = true;
        //    for (int i = 2; i < N; i++)
        //    {
        //        if (N % i == 0)
        //        {
        //            IsPrimeV1 = false;
        //            break;
        //        }
        //        return IsPrimeV1;
        //    }
        //}
        #endregion
    }

}
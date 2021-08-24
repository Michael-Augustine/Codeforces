using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 Count the Nmber Of Digit's
            //Console.WriteLine("Enter The Number");
            //int count = 0;
            //int N = Convert.ToInt32(Console.ReadLine());
            //while (N > 0)
            //{
            //    N = N / 10;
            //    count++;
            //}
            //Console.WriteLine("The Digit Is " + count);
            //Console.ReadLine();

            #endregion

            #region 2 Even Length or Odd Length
            //Console.WriteLine("Enter The Number");
            //int count = 0;
            //int N = Convert.ToInt32(Console.ReadLine());
            //while (N > 0)
            //{
            //    N = N / 10;
            //    count++; 
            //}
            //Console.WriteLine("The Length is " + count);
            //if (count%2==0)
            //{
            //    Console.WriteLine("The Count is Even Number "+count);
            //}
            //else
            //{
            //    Console.WriteLine("The Count is Odd Number "+count);
            //}
            //Console.ReadLine();

            #endregion

            #region 3 Find The Sum of Given Digit
            //Console.WriteLine("Enter The Number");
            //Int32 A = Convert.ToInt32(Console.ReadLine());
            //Int32 sum = 0;
            //Int32 count = 0;
            //Int32 B;
            //while (A > 0)
            //{
            //    B = A % 10;
            //    sum += B;
            //    A = A / 10;
            //    count++;
            //}
            //Console.WriteLine("This is --> " + count + " <-- Digit Number");
            //Console.WriteLine("Sum Of the Number is --> " + sum);
            //Console.ReadLine();

            #endregion

            #region 4.Find the sum of digits located in Odd positions of given integer
            //int oddSum = 0, num, r;
            //num = GetInteger("Enter the number");
            //while (num > 0)
            //{
            //    r = num % 10;
            //    if (r % 2 != 0)
            //    {
            //        oddSum += r;
            //    }
            //    num = num / 10;
            //}
            //Console.WriteLine("Sum of digits in Odd Positions: " + oddSum);
            //Console.ReadLine();
            #endregion

            #region 5.Find the sum of digits located in Even positions of given integer
            //int evenSum = 0, num, r;
            //num = GetInteger("Enter the number");
            //while (num > 0)
            //{
            //    r = num % 10;
            //    if (r % 2 == 0)
            //    {
            //        evenSum++;
            //    }
            //    num = num / 10;
            //}
            //Console.WriteLine("Sum of digitsin Even positions: " + evenSum);
            #endregion

            #region 6.Count the number of even digits in an integer
            //int count = 0, num;
            //num = GetInteger("Enter the number");
            //while (num > 0)
            //{
            //    num = num / 10;
            //    if (num % 2 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("The number of given the digits in Even number: " + count);

            #endregion

            #region 7.Count the number of Odd digits in an integer
            //int count = 0, num;
            //num = GetInteger("Enter the number");
            //while (num > 0)
            //{
            //    num = num / 10;
            //    Console.WriteLine(num);
            //    if (num % 2 != 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("The number of given the digits in Odd number: " + count);

            #endregion

            #region 8.Find the sum of  the odd digits in given number
            //int sum = 0, rem, num;
            //num = GetInteger("Enter the number");
            //while (num > 0)
            //{
            //    rem = num % 10;
            //    if (rem % 2 != 0)
            //    {
            //        sum += rem;
            //    }
            //    num = num / 10;
            //}
            //Console.WriteLine("Sum of the Odd digits: " + sum); 
            #endregion

            #region 9.Find the sum of the even digits in given integer
            //int evenSum = 0, num, r;
            //num = GetInteger("Enter the number");
            //while (num > 0)
            //{
            //    r = num % 10;
            //    if (r % 2 == 0)
            //    {
            //        evenSum += r;
            //    }
            //    num = num / 10;
            //}
            //Console.WriteLine("Sum of digitsin Even positions: " + evenSum);

            #endregion

            #region 10.Get the last digit of the given integer
            //int num = GetInteger("Enter the Number");
            //while (num > 0)
            //{
            //    int print = num % 10;
            //    num = num / 10;
            //    Console.WriteLine(print);
            //}
            ////num = num % 10;
            ////Console.WriteLine("Last digit: " + num);            
            #endregion

            #region 11.Get the First digit of the given integer
            //int num = GetInteger("Enter the Number");
            //while (num >=10)
            //{
            //    num = num / 10;     
            //}
            //Console.WriteLine("First Digit: "+num);
            #endregion

            #region 12.Find the first and last digts of given integer are same
            //int rem, num;
            //num = GetInteger("Enter the Integer");
            //rem = num % 10;
            //while (num >= 10){
            //    num /= 10; 
            //}
            //Console.WriteLine("First Digit: "+num);
            //Console.WriteLine("Last Digit: "+rem);
            #endregion

            #region 13.Give an integer, find the digit with max value
            //int num = GetInteger("Enter the Number");
            //int max_val=0,rem;
            //while (num > 0)
            //{
            //    rem = num % 10;
            //    if (rem >= max_val)
            //    {
            //        max_val=rem;                   
            //    }
            //    num /= 10;          
            //}
            //Console.WriteLine("Max value of digit: "+max_val);
            #endregion

            #region 15.Give an integer, find the digit with min value
            //int num = GetInteger("Enter the Number");
            //int min_val=num, rem;
            //while (num >0)
            //{
            //    rem = num % 10;
            //    if (rem <= min_val)

            //    {
            //        min_val = rem;
            //    }
            //    num /= 10;
            //}
            ////When error occur for starting index  is 0
            //Console.WriteLine("Min value of  digit: "+min_val);
            #endregion

            #region Private

            //int A = Convert.ToInt32(Console.ReadLine());
            //int B = Convert.ToInt32(Console.ReadLine()); 
            //int C = A/B;
            //Console.WriteLine("The Output is " + C);
            //Console.ReadLine();

            #endregion

            #region 18.Find the Digital root of a given integer.
            //int num = GetInteger("Enter the number");
            //int rem, rem1, sum = 0, Result = 0;
            //while (num > 0)
            //{
            //    rem = num % 10;
            //    sum += rem;
            //    num /= 10;
            //}
            //while (sum > 0)
            //{
            //    rem1 = sum % 10;
            //    Result += rem1;
            //    sum /= 10;
            //}
            //Console.WriteLine("Digital Root if given integer: "+Result);
            #endregion

            #region 20.Count how many digits are given integer N are divisible by K
            //int N, K,rem,count=0;
            //N = GetInteger("Enter the number");
            //K = GetInteger("Enter the divisible number");
            //while (N > 0)
            //{
            //    rem = N % 10;
            //    if (rem % K == 0)
            //    {
            //        count++;
            //    }
            //    N /= 10;
            //}
            //Console.WriteLine(The No of Digits: "+count);
            #endregion

            //16

            #region 17.Reverse a given integer number N

            //int remainder, reverse = 0;
            //int number = GetInteger("Enter the number");
            //while (number > 0)
            //{
            //    remainder = number % 10;
            //    number /= 10;
            //    reverse = (reverse * 10) + remainder;
            //}
            //Console.WriteLine("The reverse number is " + reverse);
            #endregion

            #region 18. Find the digital root of a given integer (Digital root means - keep adding and folding till it becomes a single digit)

            ////int N = GetInteger("Enter the number");
            ////int root = 0;
            ////int d;

            ////while (N > 0 || root > 9)
            ////{
            ////    d = N % 10;
            ////    root = root + d;
            ////    N /= 10;

            ////    if (root > 9)
            ////    {
            ////        N = root;
            ////        root = 0;

            ////    }

            ////}


            ////Console.WriteLine("Digital root is  " + root);

            #endregion

            #region MyRegion

            //int num = 128;
            //int rem;
            //while (num != 0)
            //{
            //    rem = num % 10;
            //    num /= 10;
            //    if (128 % 1 == 0 || 128 % 2 == 0 || 128 % 8 == 0)
            //    {

            //    }

            //}
            #endregion

            //19

            #region 20. Program to count how many digits of a given integer N are divisible by another positive integer K

            //int N, K,rem,count=0;
            //N = GetInteger("Enter the number");
            //K = GetInteger("Enter the divisible number");
            //while (N > 0)
            //{
            //    rem = N % 10;
            //    if (rem % K == 0)
            //    {
            //        count++;
            //    }
            //    N /= 10;
            //}
            //Console.WriteLine("The No of Digits: "+count);
            #endregion

            #region 21.Check if a given two or three digit positive integer is a palindrome or not

            //int n, r, sum = 0, temp;
            //Console.Write("Enter the Number: ");
            //n = int.Parse(Console.ReadLine());
            //temp = n;
            //while (n > 0)
            //{
            //    r = n % 10;
            //    sum = (sum * 10) + r;
            //    n = n / 10;
            //}
            //if (temp == sum)
            //    Console.WriteLine("True");
            //else
            //    Console.WriteLine("False");     
            #endregion

            #region 22. Check if the given positive long integer is palindrome or not

            //long r, sum = 0, temp;
            //Console.Write("Enter the Number: ");
            //long n = long.Parse(Console.ReadLine());
            //temp = n;
            //while (n > 0)
            //{
            //    r = n % 10;
            //    sum = (sum * 10) + r;
            //    n = n / 10;
            //}
            //if (temp == sum)
            //    Console.WriteLine("True");
            //else
            //    Console.WriteLine("False");
            //Console.ReadLine();

            #endregion


        }


        #region Input/Output Function
        public static int GetInteger(string message)
        {
            Console.WriteLine("*****Getting Input From User******");
            Console.WriteLine(message + ":");
            int temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*****************");
            return temp;
        }
        public static char GetChar(string message)
        {
            Console.WriteLine("*****Getting Input From User******");
            Console.WriteLine(message + ":");
            char temp = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("*****************");
            return temp;
        }
        public static long GetLong(string message)
        {
            Console.WriteLine("*****Getting Input From User******");
            Console.WriteLine(message + ":");
            long temp = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("*****************");
            return temp;
        }
        public static double GetDouble(string message)
        {
            Console.WriteLine("*****Getting Input From User******");
            Console.WriteLine(message + ":");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*****************");
            return temp;
        }
        public static string GetString(string message)
        {
            Console.WriteLine("*****Getting Input From User******");
            Console.WriteLine(message + ":");
            string temp = Console.ReadLine();
            Console.WriteLine("**********************************");
            return temp;
        }
        public static void PrintMessage(string message)
        {
            Console.WriteLine("*****User Output******");
            Console.WriteLine(message);
            Console.WriteLine("***********************");
        }
        #endregion

        #region Input /Output Function

        public static int GetInteger(String message)
        {
            Console.WriteLine("*****Getting Input From User******");
            Console.WriteLine(message + ":");
            int temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*****************");
            return temp;
        }
        public static bool equal(int first_digit, int last_digit)
        {
            return (first_digit == last_digit);
        }
        public static bool palindrome(int first_digit, int last_digit)
        {
            return (first_digit == last_digit);
        }

        #endregion    }
    }
}
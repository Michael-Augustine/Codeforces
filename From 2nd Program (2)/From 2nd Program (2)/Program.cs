using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set_5_question
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Program to count the number of digits in a given integer number
            //Console.WriteLine("Enter the number of digits number");
            //int n = Convert.ToInt16(Console.ReadLine());
            //int count = 0;
            //while (n > 0)
            //{
            //    n = n / 10;
            //    count++;
            //} Console.WriteLine("the count is " + count);
            //Console.ReadLine();
            #endregion

            #region 2.Check if the given number is of even length or odd length
            //Console.WriteLine("enter the number");
            //int odd = Convert.ToInt16(Console.ReadLine());
            //int count = 0;
            //while (odd > 0)
            //{
            //    odd = odd / 10;
            //    count++;
            //}
            //Console.WriteLine("the length" + count);
            //if (count % 2 == 0)
            //{
            //    Console.WriteLine("your number is add" + count);
            //}
            //else
            //{
            //    Console.WriteLine("your number is even" + count);

            //} Console.ReadLine();
            #endregion

            #region 3.Find the sum of digits of a given integer
            //Console.WriteLine("Enter the number of digits");
            //int n = Convert.ToInt16(Console.ReadLine());
            //int count = 0;
            //int sum = 0;
            //int b;
            //while (n > count)
            //{
            //    b = n % 10;
            //    sum += b;
            //    n = n / 10;
            //    count++;


            //}
            //Console.WriteLine("This is --> " + count + " <-- Digit Number");
            //Console.WriteLine("Sum Of the Number is --> " + sum);
            //Console.ReadLine();
            #endregion

            #region 4.Find the sum of digits located in the odd positions of a given integer
            //Console.WriteLine("enter the number");
            //int odd = Convert.ToInt16(Console.ReadLine());
            //int count = 0, loc;
            //while (odd > 0)
            //{
            //    odd = odd / 10;
            //    count++;
            //}
            //Console.WriteLine("the length" + count);
            //if (count % 2 == 0)
            //{

            //    Console.WriteLine("your number is add" + count);
            //}
            //else
            //{
            //    Console.WriteLine("your number is even" + count);

            //} Console.ReadLine();
            #endregion

            #region 5. Find the sum of digits located in the even positions of a given integer
            //int eve=0, loc=0;
            //Console.WriteLine("ENTER THE NUMBER");
            //int n = Convert.ToInt32(Console.ReadLine());
            //while (n > 10)
            //{
            //   loc = n % 10;
            //    if (n % 2 == 0)
            //    {   

            //        loc=eve;
            //    }
            //        Console.WriteLine("number" + loc);
            //        Console.ReadLine();

            //        n /= 10;
            //    }


            //}
            #endregion

            #region 6.&7 count the number of even digits in an Integer
            //int odd = 0, eve = 0, rem;
            //Console.WriteLine("Please enter the number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //while (n > 0)
            //{
            //    rem = n % 10;
            //    if (rem % 2 == 0)
            //    {
            //        eve++;
            //    }
            //    else
            //    {
            //        odd++;
            //    }
            //    n /= 10;


            //}
            //Console.WriteLine("odd" + odd);
            //Console.WriteLine("eve" + eve);
            //Console.ReadLine();

            #endregion

            #region 8.Find the sum of the odd digits of a given integer
            //int sum= 0,rem;
            //Console.WriteLine("Please enter the number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //while (n > 0)
            //{
            //    rem = n % 10;
            //    if (rem % 2 == 0)
            //    {
            //        sum += rem;
            //    }
            //    n = n / 10;

            //}
            //Console.WriteLine("sum od odd digits " +sum);
            //Console.ReadLine();
            #endregion

            #region  9. Find the sum of the even digits of a given integer
            //int sum = 0, rem;
            //Console.WriteLine("Please enter the number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //while (n > 0)
            //{
            //    rem = n % 10;
            //    if (rem % 2!= 0)
            //    {
            //        sum += rem;
            //    }
            //    n = n / 10;

            //}
            //Console.WriteLine("sum od eve digits " + sum);
            //Console.ReadLine();
            #endregion

            #region 10.Get the last digit of a given integer
            //int n, ld;
            //Console.WriteLine("please enter the number");
            //n = Convert.ToInt16(Console.ReadLine());
            //ld = n;
            //while (ld > 10)
            //{
            //    ld = n % 10;

            //}
            //Console.WriteLine("YOUR LAST DIGITS" + ld);

            //Console.ReadLine();

            #endregion

            #region 11. Get the FIRST digit of a given integer
            //    int n, fd;
            //    Console.WriteLine("please enter the number");
            //    n = Convert.ToInt16(Console.ReadLine());
            //    fd = n;
            //    while (fd > 10)
            //    {
            //        fd = fd / 10;

            //    }
            //    Console.WriteLine("your fd number" + fd);

            //    Console.ReadLine();
            //}
            #endregion

            #region 12.Find if the first and last digits of a given integer are the same
            //    int n, fd, ld;
            //    Console.WriteLine("enter the number");
            //    n = Convert.ToInt32(Console.ReadLine());
            //    fd = n;
            //    ld = n;
            //    while (fd > 10)
            //    {
            //        fd = fd / 10;
            //        ld = ld % 10;

            //    }

            //    Console.WriteLine("YOUR FIRST NUMBER" + fd);
            //    Console.WriteLine("your last number" + ld);
            //    Console.WriteLine("yes both number is equal    " + equal(fd, ld));
            //    Console.ReadLine();
            //}






            #endregion 

            #region 13.Given an integer, find the digit with maximum value. (I/P: 1890, O/P: 9)
            //Console.WriteLine("enter the number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int max = 0, ans;
            //while (n > 0)
            //{
            //    ans = n % 10;

            //    if (ans >= max)
            //    {
            //        max = ans;
            //    }
            //    n /= 10;
            //}
            //Console.WriteLine("max" + max);
            //Console.ReadLine();




            #endregion 
        
            #region 14.Given an integer find the location (1s, 10s, 100s, 1000s, etc.,) of the digit with maximum value
            //Console.WriteLine("enter the number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int max = 0, ans;
            //int pos=0;
            //while (n > 0)
            //{
            //    ans = n % 10;

            //    if (ans >= max)
            //    {
            //        max = ans;
            //    }
            //    n /= 10;
            //}
            //Console.WriteLine("max" + max);
            //Console.ReadLine();




            #endregion
            
            #region 15. Given an integer find the digit with minimum value. (I/P: 1890, O/P: 0
            //Console.WriteLine("enter the number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int min_val =n, ans;
            //while (n > 0)
            //{
            //    ans = n %10;

            //    if (ans<= min_val)
            //    {
            //        min_val = ans;
            //    }
            //    n /= 10;
            //}
            //Console.WriteLine("min" + min_val);
            //Console.ReadLine();

            #endregion

            #region 17.Reverse a given integer number N
            //Console.WriteLine("enter the number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int rev;
            //while (n > 0)
            //{
            //    rev = n % 10;
            //    Console.Write(rev);
            //    n /= 10;


            //} Console.ReadLine();
            #endregion

            #region 18.Find the digital root of a given integer (Digital root means - keep adding and folding till it becomes a single digit)
            //Console.WriteLine("Enter the number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0, ans;
            //while (n > 10)
            //{
            //    ans = n %10;

            //    ans += sum;
            //    ans = n / 10;

            //} Console.WriteLine("your ans" + sum);
            //Console.ReadLine();
            #endregion

            #region 24.Find the minimum number that can be formed using the digits of a given integer N.
            //Console.WriteLine("ENTER THE NUMBER");
            //int n = Convert.ToInt16(Console.ReadLine());
            //int max = 0;
            //while (n > max)
            //{ 
            //   max=


            //}


            #endregion



        }
    }

    #region 12.qual method
    //public static bool equal(int num1, int num2)
    //{ 
    //  return (num1 == num2);
    //}
    #endregion

    #region Input/Output Function
    //public static int GetInteger(string message)
    //{
    //    Console.WriteLine("**Getting Input From User***");
    //    Console.WriteLine(message + ":");
    //    int temp = Convert.ToInt32 (Console.ReadLine());
    //    Console.WriteLine("*******");
    //    return temp;
    //}
    //public static char GetChar(string message)
    //{
    //    Console.WriteLine("**Getting Input From User***");
    //    Console.WriteLine(message + ":");
    //    char temp = Convert.ToChar(Console.ReadLine());
    //    Console.WriteLine("*******");
    //    return temp;
    //}
    //public static long GetLong(string message)
    //{
    //    Console.WriteLine("**Getting Input From User***");
    //    Console.WriteLine(message + ":");
    //    long temp = Convert.ToInt64(Console.ReadLine());
    //    Console.WriteLine("*******");
    //    return temp;
    //}
    //public static double GetDouble(string message)
    //{
    //    Console.WriteLine("**Getting Input From User***");
    //    Console.WriteLine(message + ":");
    //    double temp = Convert.ToDouble(Console.ReadLine());
    //    Console.WriteLine("*******");
    //    return temp;
    //}
    //public static string GetString(string message)
    //{
    //    Console.WriteLine("**Getting Input From User***");
    //    Console.WriteLine(message + ":");
    //    string temp = Console.ReadLine();
    //    Console.WriteLine("************");
    //    return temp;
    //}
    //public static void PrintMessage(string message)
    //{
    //    Console.WriteLine("**User Output***");
    //    Console.WriteLine(message);
    //    Console.WriteLine("*********");
    //}
    #endregion
 }
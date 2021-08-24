using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Class_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1St Attempt           
            //string RE;
            //List<string> ml = new List<string>();
            
            //Console.WriteLine("Count :"+ ml.Count);
            //Console.WriteLine("Capacity :" + ml.Capacity);

            //ml.Add("Michael");
            //ml.Add("Jeny");
            //ml.Add("Guna");
            //ml.Add("Nilo");
            //ml.Add("Parkavi");            
            //ml.Add("Pink");
            //ml.Add("Ok");
            //ml.Insert(2, "Siva");
            //ml.Insert(5, "Guru");

            //Console.WriteLine("\n");

            ////ml.Remove("Michael");
            //Console.WriteLine("\n");
          
            //do{
            //    string F = Console.ReadLine();
            //if (ml.Contains(F))
            //{
            //    Console.WriteLine("Found");
            //}
            //else 
            //{
            //    Console.WriteLine("Not Found");
            //}
            //Console.WriteLine("Do You Want to Continue Yes Or No");
            //RE = Console.ReadLine();
            //Console.Clear();
            //}while((RE=="Y")||(RE=="y"));

            //Console.WriteLine("\n");
            
            ////The Capacity Of List <String> is increasing 4 by 4 
            ////Means If i don't menction the capacity of the list while 
            ////I wanted to add a new Item it will increasing the capacity 4+ 4+


            //string x = "";
            //foreach (String person in ml)
            //{
            //    x += person + "\n";
            //}
            //Console.WriteLine(x);


            //Console.WriteLine("Count :" + ml.Count);
            //Console.WriteLine("Capacity :" + ml.Capacity);
            //Console.ReadLine();
            #endregion

            #region 2nd Try
            //string End;            
            //List<int> Michael = new List<int>();
            //Console.WriteLine("Enter The Number's That You Wanna Add To Michael's List ");
            //do
            //{
            //int R = Convert.ToInt32(Console.ReadLine());
            //Michael.Add(R);
            //Console.WriteLine("Do You Want To Continue Y or N");
            //End = Console.ReadLine();
            //}            
            //while((End=="Y")||(End=="y"));         

            //String X="";
            //foreach (int Num in Michael)
            //{
            //    X += Num+"\n";
            //}

            //Michael.Sort();
            //Console.WriteLine("\n");
            //Console.WriteLine(X);
            //Console.ReadLine();
            #endregion 

            #region sorted List

            SortedList<string,int> Michael=new SortedList<string,int>();
            String N;
            Michael.Add("Idly", 8);
            Michael.Add("Dosai", 20);
            Michael.Add("Poori", 60);
            Michael.Add("Vadai", 5);
            Michael.Add("Pongal", 30);
            Console.WriteLine("Do You Want To Add More Items ? Y Or N ");
            N = Console.ReadLine();
            if ((N == "y") || (N == "Y"))
            {
                Console.WriteLine("Enter The String Value");
                string A = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter The Int Value");
                int B = Convert.ToInt32(Console.ReadLine());
                Michael.Add(A, B);
            }           
                String x = "";
                foreach (KeyValuePair<String, int> Menu in Michael)
                {
                    x += Menu.Key + "\t" + Menu.Value + "\n";
                }
                Console.WriteLine(x); 
            //do
            //{               
            //    Console.WriteLine("Do You Want To Add More Items ? Y Or N ");
            //    N = Console.ReadLine();
            //    string A = Convert.ToString(Console.ReadLine());
            //    int B = Convert.ToInt32(Console.ReadLine());               
            //}
            //while ((N == "y") || (N == "Y"));           
            Console.ReadLine();
            #endregion

        }
    }
}

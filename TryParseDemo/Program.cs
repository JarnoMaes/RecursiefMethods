using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parse
            //try
            //{
            //    int num1 = int.Parse("123");
            //    Console.WriteLine("Valid Number");

            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Not a Valid number");
            //}
            //int num1 = int.Parse("123a"); 
            //long longNum = long.Parse("123"); 
            //bool status = bool.Parse("false"); 
            //decimal deciNum = decimal.Parse("123.5");

            //Console.WriteLine(num1);
            //Console.WriteLine(longNum);
            //Console.WriteLine(status);
            //Console.WriteLine(deciNum);
            #endregion

            #region TryParse
            //int parsedInt = 0;
            //Console.WriteLine("Give a Number");
            //string input = Console.ReadLine();
            //bool isNumber = int.TryParse(input, out parsedInt );     // Try.Parse altijd een Bool.
            //if (isNumber)
            //{
            //    Console.WriteLine("Valid Number");
            //}
            //else 
            //{
            //    Console.WriteLine("Not a valid number");
            //}


            #endregion

        }




    }
}

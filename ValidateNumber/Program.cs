using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number please");
            string input = Console.ReadLine();
            isNumber(input);

            Console.WriteLine("Enter second number");
            string inputSecondNumber = Console.ReadLine();
            isNumber(inputSecondNumber);


        }
        static bool isNumber(string value) 
        {

            int number;
            if (int.TryParse(value, out number))
            {
                return true;

            }
            else 
            {
                Console.WriteLine("Not a valid number");
                return false; 
             
            }       
        }

    }
}

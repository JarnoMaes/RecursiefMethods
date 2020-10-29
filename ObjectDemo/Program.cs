using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Obj
            ////object obj = new object();
            ////obj.ToString();
            //int x = 10;
            //decimal d = 102.50m;
            //Console.WriteLine(d.ToString());      // .ToString veranderd enkel en alleen op die lijn code.
            //Console.WriteLine(x.ToString());     // .ToString veranderd enkel en alleen op die lijn code.

            //x++;
            //Console.WriteLine(x.ToString());
            #endregion



            int x = 10;
            decimal d = 105.564m;
            
            object  o = x; // Boxing
            object obj = 50; // Boxing

            x = (int)obj;   // Unboxing
            Console.WriteLine(x.ToString());
            
           
            

            
            
            




        }
    }
}

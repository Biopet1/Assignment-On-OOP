using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopPracticeClass;

namespace OopPracticeClass
{
   public class Class1
    {
        public int MyProperty { get; set; }
        public int number { get; set; }
       
        
        public static void TotalAmountForBooks(decimal v, decimal[] prices)
        {
            decimal totalAmount = 0;
            foreach (decimal singleprice in prices)
            {
                totalAmount += singleprice;
            }
            Console.WriteLine("The total amount is {0}",totalAmount);
        }
    }
    
}

class Program
{
    static void Main()
    {
        //decimal[] prices = new decimal[3];
        //prices[0] = 123m;
        //prices[1] = 245m;
        //prices[2] = 3456m;
          
        Class1 c1 = new Class1();
       c1.TotalAmountForBooks(123m,145m,267m);
    }
}

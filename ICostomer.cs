using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPracticeClass
{
    
    public interface ICostomer
    {
        void Print();
        //{
        //    Console.WriteLine("hello");
        //}
        
    }
    public class Costomer : ICostomer
    {
        public void Print()
        {
            Console.WriteLine(" Please I am inheriting from ICostomer");
        }
    }
    public class Program
    {
        public static void Main()
        {
            var costomer=new Costomer();
            costomer.Print();
        }
    }

}

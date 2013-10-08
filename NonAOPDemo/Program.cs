using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonAOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new PostSharpCalculator();
            Console.WriteLine("---------------------");
            c.Add(1, 2);
            Console.WriteLine("---------------------");
            c.Subtract(5, 4);
            Console.WriteLine("---------------------");
            c.Multiply(5, 5);
            Console.WriteLine("---------------------");
            c.Divide(6, 5);
            Console.WriteLine("---------------------");
            try
            {
                c.Divide(6, 0);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }



            Console.ReadKey();
        }
    }
}

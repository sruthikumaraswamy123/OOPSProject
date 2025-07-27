using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    public delegate void MathDelegate(int x,int y);
    public delegate string WishDelegate(string str);
    public delegate void CalculatorDelegate(int a,int b,int c );
    internal class DelDemo
    {
        public static void AddNums(int x,int y,int z)
        {
            Console.WriteLine($" the sum of given 3 no:{x + y + z}");
        }
        public static string SayHello(string Name)
        {
            return $" Hello {Name}, have a nice day!";
        }
        //static void Main(string[] args)
        //{
        //    DelDemo obj = new DelDemo();
        //    CalculatorDelegate cd = new CalculatorDelegate(AddNums);
        //    cd(10, 20, 30);
        //    WishDelegate wd = new WishDelegate(SayHello);
        //  Console.WriteLine( wd("sruthi"));
            
            
        //    Console.ReadLine();
        //}
    }
}

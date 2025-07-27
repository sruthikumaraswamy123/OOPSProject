using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    delegate void calculator(int x, int y);
    internal class practice
    {
        public  static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public  static void mul(int a, int b)
            { 
            Console.WriteLine(a * b);
        }
        static void Main(string[] args)
        {
            calculator calc = new calculator(Add);
            calc(20,30);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

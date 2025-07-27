using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    internal abstract class Class7
    {
        public void Add(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public abstract void Mul(int a, int b);
        public abstract void Div(int a, int b);

  

        static void Main(string[] args)
        {
            AbsChild obj = new AbsChild();
            obj.Add(10, 2);
            obj.sub(10, 3); obj.Mul(10, 2); obj.Div(10, 2); obj.Mod(10, 2);
            Console.ReadLine();
        }
    }

    internal class AbsChild : Class7
    {
        public override void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public override void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        public void Mod(int a, int b)
        {
            Console.WriteLine(a % b);
        }
        //static void Main(string[] args)
        //{
        //    AbsChild obj = new AbsChild();
        //    obj.Add(10, 2);
        //    obj.sub(10, 3); obj.Mul(10, 2); obj.Div(10, 2); obj.Mod(10, 2);
        //    Console.ReadLine();
        //}
    }
}

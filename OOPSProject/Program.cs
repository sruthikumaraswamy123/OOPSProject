using System.Collections.Generic;

namespace OOPSProject
{
    public class Program
    {
        //Static field  
         int y = 100; //Static field can be modified  
        //Constant field
         float pi = 3.14f; //Constant field can't be modified
        //ReadOnly field
        readonly int x = 10; //ReadOnly field can be modified only in constructor 
        //readonly int x; //ReadOnly field can be modified only in constructor
        static void Main(string[] args)
        {
            ////InOutParameters
            //InOutParameters obj = new InOutParameters();
            //uint f = 5;
            //Console.WriteLine("Value of before execution of the method:" + f);
            //obj.Factorial(ref f);
            //Console.WriteLine("Value of after execution of the method:" + f);
            //Console.ReadLine();


            ////MethodParameters
            //MethodParameters objMethod = new MethodParameters();
            //objMethod.AddParams(56.87);
            //objMethod.AddParams(78, 12.35);
            //objMethod.AddParams(12.34, 56.32, 87.21);
            //objMethod.AddParams(10, 20, 30, 40, 50);
            //Console.WriteLine();
            //objMethod.AddNums(100);
            //objMethod.AddNums(100, 100);
            //objMethod.AddNums(100, z: 100);
            //objMethod.AddNums(100, 100, 100);
            //Console.ReadLine();


            //OutPutParameters

            OutPutParameters p = new OutPutParameters();

            //int Sum1, Product1;
            //p.Math1(100, 25, out Sum1, out Product1);
            //Console.WriteLine("Sum of the given number's is:" + Sum1);
            //Console.WriteLine("Product of the given number's is:" + Product1 + "\n");
            //p.Math1(100, 25, out int Sum2, out int Product2);
            //Console.WriteLine("Sum of the given number's is:" + Sum2);
            //Console.WriteLine("Product of the given number's is:" + Product2 + "\n");
            //(int Sum3, int Product3) = p.Math2(100, 25);
            //Console.WriteLine("Sum of the given number's is:" + Sum3);
            //Console.WriteLine("Product of the given number's is:" + Product3 + "\n");

            //var (Sum4, Product4) = p.Math2(100, 25);
            //Console.WriteLine("Sum of the given number's is:" + Sum4);
            //Console.WriteLine("Product of the given number's is:" + Product4 + "\n");
            //Console.ReadLine();


            //ConDeMo
            //ConDemo cd1 = new ConDemo();
            //ConDemo cd2 = new ConDemo();
            //ConDemo cd3 = cd2;
            //cd1.Demo();
            //cd2.Demo();
            //cd3.Demo();

            //Console.ReadLine();
            //ParamConDemo
            //ParamConDemo cd1 = new ParamConDemo(100);
            //ParamConDemo cd2 = new ParamConDemo(200);
            //ParamConDemo cd3 = new ParamConDemo(300);
            //Console.ReadLine();

            //Fields

            //Console.WriteLine("Static field y is: " + y);
            //Console.WriteLine("Constant field pi is: " + pi);
            //y = 500; //Can be modified 
            //         //pi = 5.67f; //Can't be modified & error if un-commented 
            //Console.WriteLine("Modified static field y is: " + y);
            //Console.WriteLine("--------------------------------------------------");
            ////Creating instances of the class 
            //Fields s1 = new Fields(50, true);
            //Fields s2 = new Fields(150, false);
            //Console.WriteLine("Non-Static Fields: " + (s1.x + "  " + s2.x));
            //Console.WriteLine("ReadOnly Fields: " + (s1.flag + "  " + s2.flag));
            //s1.x = 100; //Can be modified 
            //s2.x = 300; //Can be modified 
            //            //s1.flag = false; //Can't be modified & Error if un-commented  
            //            //s2.flag = true; //Can't be modified & Error if un-commented 
            //Console.WriteLine("Modified Non-Static Fields: " + (s1.x + "  " + s2.x));
            //Console.ReadLine();

            //First f1 = new First();
            //First f2 = new First();
            //First f3 = new First();
            //Console.WriteLine(f1.x + "  " + f2.x + "  " + f2.x);

            //Second s1 = new Second(100);
            //Second s2 = new Second(200);
            //Second s3 = new Second(300);
            //Console.WriteLine(s1.x + "  " + s2.x + "  " + s2.x);
            //Console.ReadLine();


            AbsChild obj = new AbsChild();
            obj.Add(10, 2);
            obj.sub(10, 3); obj.Mul(10, 2); obj.Div(10, 2); obj.Mod(10, 2);
            Console.ReadLine();
        }

    }
}
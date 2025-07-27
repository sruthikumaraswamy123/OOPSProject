using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    internal class DemoClass
    {
        public string method() 
        {
            Console.WriteLine("This is a demo class method.");

            Class5 class5 = new Class5();
            class5.add(5, 10);
            class5.sub(10, 5);
            class5.Mul(2, 3);
            class5.Multiple(4, 5);
            Console.WriteLine(class5.GetName());
            // Assuming Class5 has a method to demonstrate functionality
            class5.Test1();

            return "DemoClass method executed successfully.";
        }
    }
}

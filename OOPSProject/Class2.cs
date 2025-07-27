using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProject
{
    public class Class2
    {
        int i;
        int j;
        int x;
        int y;

        //public Class2() 
        //{
        //     i = 10;
        //     j = 20;
        //}
        public Class2(int a,int b)
        {
            i = a;
            j = b;
        }
        public void class2Test1()
        {
            x = i + j;
            y = x;
        }
        public int class2Test2()
        {
            var k =i + j;
            return k;
        }
        //static void Main(string[] args)
        //{

        //}
    }
}

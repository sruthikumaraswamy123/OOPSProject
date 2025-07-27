using System.Formats.Asn1;

namespace OOPSProject
{
    public class InOutParameters
    {
        public void Factorial(ref uint a)
        {
            if (a == 0 || a == 1)
            {
                a = 1;
            }
            else
            {
                uint result = 1;
                for (uint i = 2; i <= a; i++)
                {
                    result = result * i;
                }
                a = result;
            }

        }
        //private static void Main()
        //{
        //    InOutParameters obj = new InOutParameters();
        //    uint f = 5;
        //    Console.WriteLine("Value of before execution of the method:" + f);
        //    obj.Factorial(ref f);
        //    Console.WriteLine("Value of after execution of the method:" + f);
        //    Console.ReadLine();
        //}
    }
}

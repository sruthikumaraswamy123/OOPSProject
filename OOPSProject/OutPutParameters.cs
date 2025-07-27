namespace OOPSProject
{
    public class OutPutParameters
    {
        public void Math1(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a * b;
        }
        public (int, int) Math2(int a, int b)
        {
            int c = a + b;
            int d = a * b;
            return (c, d);
        }
        //private static void Main()
        //{
        //    OutPutParameters p = new OutPutParameters();

        //    int Sum1, Product1;
        //    p.Math1(100, 25, out Sum1, out Product1);
        //    Console.WriteLine("Sum of the given number's is:" + Sum1);
        //    Console.WriteLine("Product of the given number's is:" + Product1 + "\n");


        //    p.Math1(100, 25, out int Sum2, out int Product2);
        //    Console.WriteLine("Sum of the given number's is:" + Sum2);
        //    Console.WriteLine("Product of the given number's is:" + Product2 + "\n");

        //    (int Sum3, int Product3) = p.Math2(100, 25);
        //    Console.WriteLine("Sum of the given number's is:" + Sum3);
        //    Console.WriteLine("Product of the given number's is:" + Product3 + "\n");

        //    var (Sum4, Product4) = p.Math2(100, 25);
        //    Console.WriteLine("Sum of the given number's is:" + Sum4);
        //    Console.WriteLine("Product of the given number's is:" + Product4 + "\n");


        //}
    }
}


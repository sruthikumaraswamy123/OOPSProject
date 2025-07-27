namespace OOPSProject
{
    internal class Class4: IStudent
    {
        public Class4()
        {
            Console.WriteLine("Class2 constructor is called.");
        }

        public int add(int a, int b)
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }

        public void Mul(int a, int b)
        {
            throw new NotImplementedException();
        }

        public void Test3()
        {
            Console.WriteLine("Method 3");
        }
        public void Test4()
        {
            Console.WriteLine("Method 4");
        }
      //  static void Main()
        //{
        //    Class4 c = new Class4();
        //   // Class4 p = c;
        //    //c.Test1(); 
        //    //c.Test2(); //Calling members of parent class 
        //    c.Test3(); c.Test4(); //Calling members of current class 
        //    Console.ReadLine();
        //}
    }
}

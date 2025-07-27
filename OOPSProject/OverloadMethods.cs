namespace OOPSProject
{
    internal class OverloadMethods
    {
       public void show()
        {
            Console.WriteLine(1);
        }
        public void show(int i)
        {
            Console.WriteLine(2);
        }
        public void show(string s)
        {
            Console.WriteLine(3);
        }
        public void show(int i,string s)
        {
            Console.WriteLine(4);
        }
        public void show(string s,int i)
        {
            Console.WriteLine(5);
        }
        static void main()
        {
            OverloadMethods obj = new OverloadMethods();
            obj.show();
            obj.show(1);
            obj.show("sruthi");
            obj.show(10, "ram");
            obj.show("bunty", 20);
            Console.ReadLine();
        }
    }
}

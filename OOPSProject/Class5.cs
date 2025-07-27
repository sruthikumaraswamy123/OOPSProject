
namespace OOPSProject
{
    internal class Class5 : Class1, IStudent, ITeacher
    {
        public Class5()
        {
            Console.WriteLine("Constructor is called");
        }

        public int add(int a, int b)
        {
            const int pi = 3; // Assuming 'pi' is a constant value
            return (a + pi);
        }

        // Fix: Removed invalid member declaration and moved the method call to a valid context

        public string GetName()
        {
            return "Default Name";
        }

        public void Mul(int a, int b)
        {
            Console.WriteLine($"Multiplication: {a * b}");
        }

        public void Multiple(int a, int b)
        {
            Console.WriteLine($"Multiple: {a * b}");
        }

        public void sub(int a, int b)
        {
            Console.WriteLine($"Subtraction: {a - b}");
        }



        public void Main()
        {
            Class5 class5 = new Class5();
            class5.add(5, 10);
            class5.sub(10, 5);
            class5.Mul(2, 3);
            class5.Multiple(4, 5);
            Console.WriteLine(class5.GetName());
            // Assuming Class5 has a method to demonstrate functionality
            class5.Test1();
        }

    }
}

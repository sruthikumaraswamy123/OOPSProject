namespace OOPSProject
{
    public  class Emp
    {
        public int? Id;
        public String? Name, Job;
        public double? Salary;
        public bool? Status;
    }
    public class UserDefinedTypes
    {
        public Emp GetEmpDetails(int Id)
        {
            Emp emp = new Emp();
            emp.Id = Id;
            emp.Name = "sruthi";
            emp.Job = "Manager";
            emp.Salary = 50000.00;
            emp.Status = true;
            return emp;
        }
        //static void Main()
        //{
        //    UserDefinedTypes udt = new UserDefinedTypes();
        //    Emp obj = udt.GetEmpDetails(1001);
        //    Console.WriteLine(obj.Id + " " + obj.Name + " " + obj.Job + " " + obj.Salary + "" + obj.Status);
        //    Console.ReadLine();
        //}
    }
}
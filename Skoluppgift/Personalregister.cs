namespace Skoluppgift
{
    internal class Personalregister
    {
        static void Main(string[] args)
        {
            var users = new Employees();
            //var users2 = new Employees();
           
            Console.Write("Add employee: ");
            string user1 = Console.ReadLine();
            
            Console.Write("Add employee salary: ");
            decimal user2 = Convert.ToDecimal(Console.ReadLine());
            
            users.AddNEmployeeName(user1);
            users.AddEmployeeSalary(user2);

            users.GetEmployeeInformation();

            //user2.AddNEmployeeName("nils");
            //user2.AddEmployeeSalary(200);


            //user.GetEmployeeInformation();
            //user2.GetEmployeeInformation();

        }
    }
}
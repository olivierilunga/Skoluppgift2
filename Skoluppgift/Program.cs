namespace Skoluppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee("Nils Kalsson Pyssling", 47000);
            var regi = new Register();

            //emp.ToString();

            //regi.AddEmployee();

            //regi.AddEmployee("Newton", 62000);

            do
            {
              //  ShowMainMeny();
                string input = Console.ReadLine()!;

                switch (input)
                {
                    case "1":

                        break;

                    case "2":
                        regi.GetEmployeesInformation();
                        break;

                    case "3":

                        break;

                    case "4":

                        break;

                    case "5":

                        break;

                    case "6":

                        break;

                    case "7":

                        break;

                    default:
                        Console.WriteLine("");
                        break;
                }

            } while (true);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift2
{
    public class Manu
    {
        public void MainMenu()
        {

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to local cinema");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Main Manu".ToUpper());
            Console.WriteLine(@"(1.) Start\n (2.) Calculate total price for your company\n(0.) Quit");

            string input = Console.ReadLine()!.ToLower();
            // int option = Convert.ToInt32(input);
            bool quit = false;

            while (quit)
            {
                switch (input)
                {
                    case "1":
                        Start();
                        break;
                    case "2":
                        CompanyPrice();
                        break;
                    case "0":
                        quit = true;
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong input.");
                        break;
                }
            }
        }

        private void CompanyPrice()
        {
           
        }

        private void Start()
        {
            Console.WriteLine("How old are you: ");
            bool num = int.TryParse(Console.ReadLine(), out int user);
            while (num)
            {
                if (user <= 20)
                {
                    Console.WriteLine($"{Person.Youth}\nPrice: {Expense.youthPrice.ToString("C")}");
                }
                else if (user >= 64)
                {
                    Console.WriteLine($"{Person.Pensioner}\nPrice: {Expense.pensionerPrice.ToString("C")}");
                }
                else
                {
                    Console.WriteLine($"Price: {Expense.price.ToString("C")}");
                }
            }
        }
    }
}

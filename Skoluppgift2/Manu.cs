using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift2
{
    public class Manu
    {
        Expense start = new();
        public void MainMenu()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Welcome to local cinema\n\n".ToUpper());

            bool quit = false;

            while (!quit)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Main Manu".ToUpper());
                Console.WriteLine("1). Start\n2). Calculate total price for your company\n0). Quit");
                string input = Console.ReadLine()!.ToLower();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        start.VerifyUser();
                        break;
                    case "2":
                        Console.Clear();
                        start.TotalPrice();
                        break;
                    case "0":
                        Console.Clear();
                        quit = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong input. try again");
                        Console.Clear();
                        continue;
                }
            }
        }
    }
}

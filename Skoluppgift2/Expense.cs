using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift2
{
    public class Expense
    {
        private readonly int _youthPrice = 80;
        private readonly int _pensionerPrice = 90;
        private readonly int _adultPrice = 120;

        int currentPrice = 0;
        int _totalPrice = 0;
        int customers = 0;

        Manu manu = new Manu();

        public int TotalPrice()
        {
            //int[] price = new int[3] /*{ _youthPrice, _pensionerPrice, _regularPrice }*/;
            // _totalPrice += price[0];

            Console.WriteLine("Hello, how old are you: ");
            bool input = int.TryParse(Console.ReadLine()!, out int userInput);

            while (input)
            {
                //int userAge = Convert.ToInt32(Console.ReadLine());
                //_totalPrice += currentPrice;
                if (userInput <= 20)
                {
                    Console.WriteLine($"How many youths: ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                    currentPrice += _youthPrice * userInput;
                    _totalPrice += currentPrice;
                    Console.WriteLine("Current price for you is: {0}", currentPrice.ToString("C"));
                    continue;
                }
                else if (userInput >= 64)
                {
                    Console.WriteLine($"How many pensioners: ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                    currentPrice += _pensionerPrice * userInput;
                    _totalPrice += currentPrice;
                    Console.WriteLine("Current price for you is: {0}", currentPrice.ToString("C"));
                    continue;
                }
                else if (userInput > 21 || userInput < 63)
                {
                    Console.WriteLine($"How many adults: ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                    currentPrice += _adultPrice * userInput;
                    _totalPrice += currentPrice;
                    Console.WriteLine("Current price for you is: {0}", currentPrice.ToString("C"));
                    continue;
                }
                Console.WriteLine("$the total price is: {0}", _totalPrice.ToString("C"));
                Console.Clear();
            }

            return _totalPrice;
        }
        public void VerifyUser()
        {

            Console.WriteLine("How old are you: ");
            bool customerAge = int.TryParse(Console.ReadLine(), out int user);
            while (customerAge)
            {
                if (user <= 20)
                {
                    Console.WriteLine($"{Person.Youth}\nPrice: {_youthPrice.ToString("C")}");
                    Console.Clear();
                    break;
                }
                else if (user >= 64)
                {
                    Console.WriteLine($"{Person.Pensioner}\nPrice: {_pensionerPrice.ToString("C")}");
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine($"{Person.Adult}\nPrice: {_adultPrice.ToString("C")}");
                    Console.Clear();
                    break;
                }
            }
        }
        private void CompanyPrice()
        {
            //Console.WriteLine("Hello, how old are you: ");
            //bool input = int.TryParse(Console.ReadLine()!, out int userInput);
            //customers++;
            //while (input)
            //{
            //    Console.WriteLine("");
            //    if (userInput <= 20)
            //    {
            //        Console.WriteLine($"{Person.Youth}\nPrice: {_youthPrice.ToString("C")}");
            //        break;
            //    }
            //    else if (userInput >= 64)
            //    {
            //        Console.WriteLine($"{Person.Pensioner}\nPrice: {_pensionerPrice.ToString("C")}");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{Person.Adult}\nPrice: {_regularPrice.ToString("C")}");
            //        break;
            //    }
            //}
        }
    }
}

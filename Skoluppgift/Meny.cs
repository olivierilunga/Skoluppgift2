using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift
{
    public class Meny
    {
        Register register = new Register();
        public Meny()
        {
            ShowMainMeny();
        }

        private static void ShowMainMeny()
        {
            Console.WriteLine("1. add employee");
            Console.WriteLine("2. print employee");
            Console.WriteLine("Q. quit");
        }

    }
}

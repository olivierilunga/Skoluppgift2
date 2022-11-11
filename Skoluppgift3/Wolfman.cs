using Skoluppgift3.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift3
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(int age, string name, double weight, string description, bool isWithThePac) : base(age, name, weight, description, isWithThePac)
        {
        }

        public void Talk(string? talks)
        {
            Console.Write(talks = "I am the Wolfman!".ToLower());
        }
    }
}

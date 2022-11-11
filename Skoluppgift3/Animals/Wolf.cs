using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift3.Animals
{
    internal class Wolf : Animal
    {
        bool IsWithThePac = false;
        public Wolf(int age, string name, double weight, string description, bool isWithThePac) : base(age, name, weight, description)
        {
            IsWithThePac = isWithThePac;
        }

        public override string DoSound(string sounds)
        {
            sounds = "AAhooo!".ToUpper();
            return sounds;
        }
    }
}

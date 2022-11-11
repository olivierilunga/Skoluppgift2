using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift3.Animals
{
    internal class Dog : Animal
    {
        string race = string.Empty;
        public Dog(int age, string name, double weight, string description, string race) : base(age, name, weight, description)
        {
            this.race = race;
        }

        public override string DoSound(string sounds)
        {
            sounds = "Wooff!".ToUpper();
            return sounds;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift3.Animals
{
    internal class Worm : Animal
    {
        bool IsPoisonous = false;
        public Worm(int age, string name, double weight, string description, bool isPoisonous) : base(age, name, weight, description)
        {
            IsPoisonous = isPoisonous;
        }

        public override string DoSound(string sounds)
        {
            sounds = "sssssssss".ToUpper();
            return sounds;
        }
    }
}

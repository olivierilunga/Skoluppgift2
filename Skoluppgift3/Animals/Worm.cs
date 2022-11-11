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

        public override string Stats(int age, string name, double weight, string description)
        {
            return base.Stats(age, name, weight, description);
        }
        public override string DoSound()
        {
            string sounds = "sssssssss".ToUpper();
            return sounds;
        }
    }
}

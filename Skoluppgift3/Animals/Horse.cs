using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift3.Animals
{
    internal class Horse : Animal
    {
        int _speedPerHour;
        public Horse(int age, string name, double weight, string description, int speedPerHour = 0) : base(age, name, weight, description)
        {
            _speedPerHour = speedPerHour;
        }

        public override string Stats(int age, string name, double weight, string description)
        {
            return base.Stats(age, name, weight, description);
        }
        public override string DoSound()
        {
            string sounds = "iieehhheeeee".ToUpper();
            return sounds;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift3.Animals.Birds
{
    internal class Bird : Animal
    {
        readonly double WingSpan;
        public Bird(int age, string name, double weight, string description, double wingSpan) : base(age, name, weight, description)
        {
            WingSpan = wingSpan;
        }

        public override string DoSound(string sounds)
        {
            sounds = "Piippii";
            return sounds;
        }
    }
}

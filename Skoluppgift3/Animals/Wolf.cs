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

        public override string Stats(int age, string name, double weight, string description)
        {
            return base.Stats(age, name, weight, description);
        }
        public override string DoSound()
        {
            string sounds = "AAhooo!".ToUpper();
            return sounds;
        }
    }
}

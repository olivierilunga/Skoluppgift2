using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift3.Animals.Birds
{
    internal class Flamingo : Bird
    {
        readonly string _color = string.Empty;

        public Flamingo(int age, string name, double weight, string description, double wingSpan, string color) : base(age, name, weight, description, wingSpan)
        {
            _color = color;
        }
    }
}

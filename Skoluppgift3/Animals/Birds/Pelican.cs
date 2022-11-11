using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift3.Animals.Birds
{
    internal class Pelican : Bird
    {
        readonly double _height;
        public Pelican(int age, string name, double weight, string description, double wingSpan, double height) : base(age, name, weight, description, wingSpan)
        {
            _height = height;
        }
    }
}

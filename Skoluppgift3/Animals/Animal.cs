using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift3.Animals
{
    internal abstract class Animal
    {
        public int Age { get; set; } = 0;
        public string? Name { get; set; }
        public double Weight { get; set; }
        public string Description { get; set; } = string.Empty;

        public Animal(int age, string name, double weight, string description)
        {
            Age = age;
            Name = name;
            Weight = weight;
            Description = description;
        }
        public abstract string DoSound(string sounds);
    }
}

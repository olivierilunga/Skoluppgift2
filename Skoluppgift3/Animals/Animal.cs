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

        //I den här klassen kan man lägga till attribut så att samtliga animal får samma attribut.

        public Animal(int age, string name, double weight, string description)
        {
            Age = age;
            Name = name;
            Weight = weight;
            Description = description;
        }

        public virtual string Stats(int age, string name, double weight, string description)
        {
            Age = age;
            Name = name;
            Weight = weight;
            Description = description;
            return string.Format("Age: {0} Name: {1} Weight: {2} Description: {3}", Age.ToString(), Name, Weight, Description);
        }
        public abstract string DoSound();
    }
}

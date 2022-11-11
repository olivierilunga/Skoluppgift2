using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift3.Animals
{
    internal class Hedgehog : Animal
    {
        int _nrOfSpikes;
        public Hedgehog(int age, string name, double weight, string description, int nrOfSpikes) : base(age, name, weight, description)
        {
            _nrOfSpikes = nrOfSpikes;
        }
        public override string Stats(int age, string name, double weight, string description)
        {
            return base.Stats(age, name, weight, description);
        }

        public override string DoSound()
        {
            string sounds = "ssnnoooorrrg!";
            return sounds;
        }
    }
}

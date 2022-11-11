using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift3.Animals.Birds
{
    internal class Swan : Bird
    {
        readonly bool _hasChildren = false;
        public Swan(int age, string name, double weight, string description, double wingSpan, bool hasChildren) : base(age, name, weight, description, wingSpan)
        {
            _hasChildren = hasChildren;
        }
    }
}

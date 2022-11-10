using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift3
{
    internal class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            throw new NotImplementedException("You tried to use a numeric only field. This fired an rror!");
        }
    }
}

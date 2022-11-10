using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift3
{
    internal class DoneError : UserError
    {
        public override string UEMessage()
        {
            throw new Exception("You are not done yet!");
        }
    }
}

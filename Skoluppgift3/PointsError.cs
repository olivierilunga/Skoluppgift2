using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift3
{
    internal class PointsError : UserError
    {
        public override string UEMessage()
        {
            throw new Exception("You added wrong points!");
        }
    }
}

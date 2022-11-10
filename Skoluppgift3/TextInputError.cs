using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Skoluppgift3
{
    internal class TextInputError : UserError
    {
        public override string UEMessage()
        {
            throw new ArgumentException("You tried to use a textinput in a numeric only field.This fired an error!");
        }
    }
}

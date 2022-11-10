using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift3
{
    internal class ThoughtsError : UserError
    {
        public override string UEMessage()
        {
            throw new Exception("Overthinking tends to be worse among women. And too much thinking can lead to mental health issues such as depression and anxiety, emotional distress, and self-destructive behaviours");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar.Exceptions
{
    class MufajNullException : Exception
    {
        public MufajNullException()
        {
        }

        public MufajNullException(string message)
            : base(message)
        {
        }

        public MufajNullException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar.Exceptions
{
    class KolcsonzoNevNullException : Exception
    {
        public KolcsonzoNevNullException()
        {
        }

        public KolcsonzoNevNullException(string message)
            : base(message)
        {
        }

        public KolcsonzoNevNullException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar.Exceptions
{
    class IroNullException : Exception
    {
        public IroNullException()
        {
        }

        public IroNullException(string message)
            : base(message)
        {
        }

        public IroNullException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar.Exceptions
{
    class OlvasojegyNullException : Exception
    {
        public OlvasojegyNullException()
        {
        }

        public OlvasojegyNullException(string message)
            : base(message)
        {
        }

        public OlvasojegyNullException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

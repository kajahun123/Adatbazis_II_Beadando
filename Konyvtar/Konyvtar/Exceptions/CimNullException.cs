using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar.Exceptions
{
    class CimNullException : Exception
    {
        public CimNullException()
        {
        }

        public CimNullException(string message)
            : base(message)
        {
        }

        public CimNullException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

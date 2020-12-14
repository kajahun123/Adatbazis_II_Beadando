using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konyvtar.Exceptions;

namespace Konyvtar.Models.Records
{
   public class Konyvek
    {
        private string olvasojegy;
        private string kolcsonzoNev;
        private string cim;
        private string iro;
        private string mufaj;
        private DateTime kolcsonzesDate;


        //SAJÁT KIVÉTELEK!!!!!
        public string Olvasojegy
        {
            get
            {
                return olvasojegy;
            }
            set
            {
                if (value == null)
                {
                    throw new OlvasojegyNullException("Az olvasójegy kódja nem lehet üres!");
                }
                olvasojegy = value;
            }
        }
        public string KolcsonzoNev
        {
            get
            {
                return kolcsonzoNev;
            }
            set
            {
                if (value == null)
                {
                    throw new KolcsonzoNevNullException("A kölcsönző neve nem lehet üres!");
                }
                kolcsonzoNev = value;
            }
        }

        public string Cim
        {
            get
            {
                return cim;
            }
            set
            {
                if (value == null)
                {
                    throw new CimNullException("A könyv címe nem lehet üres!");
                }
                cim = value;
            }
        }


        public string Iro
        {
            get
            {
                return iro;
            }
            set
            {
                if (value == null)
                {
                    throw new IroNullException("Az Író neve nem lehet üres!");
                }
                iro = value;
            }
        }

        public string Mufaj
        {
            get
            {
                return mufaj;
            }
            set
            {
                if (value == null)
                {
                    throw new MufajNullException("A könyv műfaja nem lehet üres!");
                }
                mufaj = value;
            }
        }

        public DateTime KolcsonzesDate
        {
            get
            {
                return kolcsonzesDate;
            }
            set
            {
                kolcsonzesDate = value;
            }
        }
    }
}

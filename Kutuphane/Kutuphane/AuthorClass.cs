using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class AuthorClass
    {
        public string _id;

        public string _adi;

        public string _soyadi;

        public AuthorClass(string id,string ad, string soyad)
        {
            _id = id;
            _adi = ad;
            _soyadi = soyad;
        }

        public override string ToString()
        {
            return _adi + " " + _soyadi;
        }
    }
}

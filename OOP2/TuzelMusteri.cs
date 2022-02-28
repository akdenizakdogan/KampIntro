using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //inheritance olayı. Tuzel musteri bir müsteridir.
    class TuzelMusteri:Musteri
    {
        //Individual- Coorporate Customer.
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }

    }
}

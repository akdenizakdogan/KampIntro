using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Musteri
    {
        //classlar icinde ya özellik ya operasyon tutar. hatırlatma
        public int Id { get; set; }
        public string MusteriNo { get; set; }

        //Tuzel ve gercek müsteriyi inheritance ile müsteri olarak atadığım için buradaki özellikler diğer iki classta geçerli olur.
    }
}

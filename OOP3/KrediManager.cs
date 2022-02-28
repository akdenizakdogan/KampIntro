using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();

        // Interfaceleri birbirinin alternatifi olan ama kod icerikleri farklı olan durumlar icin kullanırız. Bu örnek icin kredi türlerinin hepsinde ödeme planı vardır fakat hesaplama işleri değişkenlik gösterir.
        //Projede loglama yapmak istiyoruz diyelim. Kim ne zaman hangi operasyonu cagirdi. Sistemde olan hareketleri döktügümüz döküm.

    }
}

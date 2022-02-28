using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        //Method Injection              Constructor Injection araştır.
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();      // böyle yazarsan hepsini konut kredi ye bagladin bu yüzden

            krediManager.Hesapla();
            loggerService.Log();


        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}

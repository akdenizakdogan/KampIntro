using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface inheritance abstract nesneleri gerçek hayatta uygulamak.
            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID yazılım geliştirme tekniğinin L harfi.

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Akdeniz";
            musteri1.Soyadi = "Akdogan";
            musteri1.TcNo = "12345678910";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "SoftwareLtd";
            musteri2.VergiNo = "1234567890";


            Musteri musteri3 = new GercekMusteri();         // Musteri Gercek Musteri ve Tuzel Musteriyi tutabiliyor Dikkat!
            Musteri musteri4 = new TuzelMusteri();          // Musteri Classı hem gercek hem tuzel musteri classlarının referanslarını tutabiliyor.

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);







        }
    }
}

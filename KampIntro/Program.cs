using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.46;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 7.55;
            double dolarBugün = 7.45;

            if (dolarDun > dolarBugün)
            {
                Console.WriteLine("Azalis butonu");
            }
            else if (dolarDun < dolarBugün)
            {
                Console.WriteLine("Artis butonu");
            }
            else
            {
                Console.WriteLine("Degismedi butonu");
            }

            Console.WriteLine(kategoriEtiketi);

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanici ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
        }
    }
}

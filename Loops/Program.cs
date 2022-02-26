using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Gelistirici Yetistirme Kampi";
            string kurs2 = "Programlamaya baslangic icin temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            // array - dizi
            string[] kurslar = new string[] { "Yazılım Gelistirici Yetistirme Kampi", "Programlamaya baslangic icin temel kurs", "Java", "Python","C++" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti.");

            foreach (string kurs in kurslar)    //dizileri kolay dolasmak icin kullaniriz.
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu - footer");


        }
    }
}

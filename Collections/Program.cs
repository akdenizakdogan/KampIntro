using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Akdeniz","Arda","Gurkan","Cansin" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];    // önceki array i iptal etti 5 birimlik boş bir array oluşturdu.
            //isimler[4] = "İlker";       // Sonra gitti boş array in 4. elemanını ilker yaptı. Bu yüzden collections kullanıyoruz.
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);


            List<string> isimler2 = new List<string>() { "Akdeniz", "Arda", "Gürkan", "Cansin" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]); //Değerleri kaybetme olayın ortadan kalktı.

            //Listenin belirli fonksiyonlarını arastir.

            



        }
    }
}

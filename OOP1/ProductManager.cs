using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        //Manager isimlendirmesi görürsen ya da service, ürünle ilgili operasyonların oldugunu anla. CRUD operasyonları burada yapılır.

        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "guncellendi.");
        }

        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
        //public void Topla2(int sayi1,int sayi2)
        //{
        //    Console.WriteLine(sayi1+sayi2);
        //}
        
    }
}

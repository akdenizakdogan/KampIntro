using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;    // kategori 2 mobilyaya denk geldigini varsayalım.
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //ya da böyle de olusturulabilir ;

            Product product2 = new Product { Id =2, CategoryId =5, UnitsInStock=5, ProductName="Kalem", UnitPrice=35};

            //Pascalcase    //camelCase
            ProductManager productManager = new ProductManager();
            // string isim = "Akdeniz"; gibi bir şey yukarıda yazdığın.
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //productManager.Topla2(3, 6);//çıkışında elde ettiğim sonucu başka bir yerde kullanamam

            //int toplamaSonucu = productManager.Topla(3, 6);
            //Console.WriteLine(toplamaSonucu*2);     // elde ettiğim sonucu başka bir yerde kullanabildim. Bu yüzden returnleri kullanıyoruz.


            

        }
    }
}

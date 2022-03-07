using DataAccess.Concrete.InMemory;
using Business.Concrete;
using System;
using DataAccess.Concrete.EfCarDal;
using DataAccess.Concrete.EntityFramework;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            // BrandTest();
           // ColorTest();

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                System.Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                System.Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetProductDetails())
            {
                System.Console.WriteLine(car.Description+"/" + car.BrandName+"/" +car.ColorName);
            }
        }
    }
}

using DataAccess.Concrete.InMemory;
using Business.Concrete;
using System;


namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());       //Ben InMemory calisicam diyorum.
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.DailyPrice);

            }

        }
    }
}

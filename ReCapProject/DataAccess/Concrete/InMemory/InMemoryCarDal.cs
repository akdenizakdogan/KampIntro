using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            //elimde bir database yok. Veri geliyormuş gibi test ediyorum.
            _cars = new List<Car>
            {
                new Car {CarId=1,BrandId=1,ColorId=1,ModelYear="2022",DailyPrice=400000,Description="Coupe1"},
                new Car {CarId=2,BrandId=1,ColorId=3,ModelYear="2021",DailyPrice=500000,Description="Coupe2"},
                new Car {CarId=3,BrandId=2,ColorId=6,ModelYear="2023",DailyPrice=600000,Description="Coupe3"},
                new Car {CarId=4,BrandId=3,ColorId=7,ModelYear="2024",DailyPrice=700000,Description="Coupe4"},
                new Car {CarId=5,BrandId=3,ColorId=2,ModelYear="2025",DailyPrice=800000,Description="Coupe5"},
                new Car {CarId=6,BrandId=4,ColorId=1,ModelYear="2026",DailyPrice=900000,Description="Coupe6"},
                new Car {CarId=7,BrandId=5,ColorId=7,ModelYear="2027",DailyPrice=100000,Description="Coupe7"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;

            carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}

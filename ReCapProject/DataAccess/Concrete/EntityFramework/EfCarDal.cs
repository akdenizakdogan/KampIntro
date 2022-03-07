using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EfCarDal
{
    public class EfCarDal : EfEntityRepositoryBase<Car, NewDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (NewDatabaseContext context = new NewDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             from a in context.Cars
                             join r in context.Colors on a.ColorId equals r.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandId = c.BrandId,
                                 ColorId = c.ColorId,
                                 BrandName = b.BrandName,
                                 ColorName = r.ColorName,
                                 Description = c.Description
                             };
                return result.ToList();                    
            }
        }
    }
}

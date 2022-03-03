using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{

    //NuGet

    //İlerleyen asamalarda BaseEfRepository leri de olusturup bu kodu tekrarlamanın önüne gecilecek.

    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //Yazdığımız kod daha sonra daha da iyilestirilecek. Amac olayı anlamak
            //IDisposable Pattern implementain of c# search.
            //Using bittiği anda garbage collector le belleği hızlıca temizle demek.
            using (NorthwindContext context= new NorthwindContext())    
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);      
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);      //sadece birini getir

            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                // Filtre null mı=? Null sa hepsini getir, degilse filtreyi uygula
                     return filter == null ? context.Set<Product>().ToList() 
                    : context.Set<Product>().Where(filter).ToList();

            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

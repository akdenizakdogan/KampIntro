using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess 
{

    //where T:class,IEntity      Class---referans tip olabilir, IEntity olabilir veya Ientity implemente eden bir nesne olabilir.
    // new() : new'lenebilir olmalı. Bunu ekleyince IEntity den kurtuluyorum. Çünkü newlenebilir olmalı. IEntity newlenemez. ;) 
    //Sadece IEntitydeki nesneleri eklenebilir hale getirdik.
    public interface IEntityRepository<T> where T:class,IEntity,new()    //Burdaki bana calisacagim tipi söyle demek hatırla. Category dersem category, product dersem product. Ben bu T
        //Leri sınırlandırmak istiyorum. Bu T ler ne olsun istiyoruz ? Veri Tabanı Nesnelerim yazılabilsin istiyorum. Bunu T yi sınırlandırarak yapalım.
        //Generic Constraint

    {
        //Olusturacagımız her bir interface'te sonucta aynı seyleri kurguluyoruz.
        //Sürekli olarak aynı seyleri yazmak yerine, bu kalıp halindeki terimleri IEntityRepository gibi bir interface sınıfında hazırlayıp
        //sonra bunları olusturmak istedigimiz interfacelere entegre etmemiz bize kolaylık sağlayacaktır.
        //Bu operasyonu Generic Repository Design Pattern olarak adlandırıyoruz.

        List<T> GetAll(Expression<Func<T,bool>> filter=null);       //Product manager'da expression verebilmeni sağlayan yapı burdaki expression. Ürünleri kategoriye göre listele vsvs gibi.
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

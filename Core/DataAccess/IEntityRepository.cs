using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Core.DataAccess
{
    // generic constraint
    // class : referans tip 
    // IEntity olabilir veya ientity implemente den bir nesene olabilir
    // IEntity'nin kendisinide constraint'de kabul göreceği için new kısıtlamasını da getirdim bu yüzden interfaceler newlenemeyeceği için IEntity objesi kullanılamaz
    public interface IEntityRepository<T> where T : class,IEntity,new () // class olabilir değil referans tip olabilir yazdım
    {
        // filtreleme yapabilmek için expression kullanıyorsun
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        // tek tek filtreleme yapmanı sağlayacak
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{

    // Generic constraint
    // class: referans tip 
    //IEntity: IEntity olabilir yada IEntity implemente eden bir sınıf olabilir
    //new: new'lenebilir olmalı.IEntity bir interface olduğundan new'lenemez bu yüzden de interfacei implement eden sınıfları kullan demiş oluruz
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {

        List<T> GetAll(Expression<Func<T,bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Udate(T entity);

        void Delete(T entity);

    }
}

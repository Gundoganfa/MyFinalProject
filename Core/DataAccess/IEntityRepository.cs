using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Generic Constraint
    //class: referans tip
    //IEntity : IEntity veya IEntity implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalı (IEntity'nin kendisi new'lenemez, onu implemente eden classlar new'lenebilir)
    //new'lenebilmek demek: gelen tipin non-abstract, bu projede concrete bir tip olması gerektiğini ifade eder.
    public interface IEntityRepository <T> where T:class, IEntity, new()
        // Dal veya Dao uzantısı piyasa standardıdır, DAL c#cılar, DAO genelde Javacılar tarafından kullanılıyor.
    {        
        // interface methodları default olarak public'tir.
        List<T> GetAll(Expression<Func<T,bool>> filter=null); // GetAll product tipinde bir liste döndürüyor.
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

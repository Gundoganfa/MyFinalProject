 // Dal veya Dao uzantısı piyasa standardıdır, DAL c#cılar, DAO genelde Javacılar tarafından kullanılıyor.
 
 //Generic Constraint
    //class: referans tip
    //IEntity : IEntity veya IEntity implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalı (IEntity'nin kendisi new'lenemez, onu implemente eden classlar new'lenebilir)
    //new'lenebilmek demek: gelen tipin non-abstract, bu projede concrete bir tip olması gerektiğini ifade eder.
    public interface IEntityRepository <T> where T:class, IEntity, new()
 
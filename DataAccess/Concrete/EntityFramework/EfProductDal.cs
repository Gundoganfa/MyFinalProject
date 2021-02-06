using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal 
    { // yapıyı bu şekilde tanıyoruz, IProductDal'ın imzasındaki methodların tamamı EfEntityRepositoryBase içinde vardır.
    }
}

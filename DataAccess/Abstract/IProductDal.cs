using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        //ürüne özel methodlar eklemek için burayı kullanacağız.
        List<ProductDetailDto> GetProductDetails();
    }
}

//Code refactoring = Kodun iyileştirilmesi adı verilir.
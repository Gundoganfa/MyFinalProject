using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal iProductDal)
        {
            // Constructor
            _productDal = iProductDal;
        }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length <2 )
            {
                //magic strings
                //return new ErrorResult("Ürün ismi en az 2 karakter olmalıdır");
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
            //return new SuccessResult(); // bu da mümkün
        }

        public IDataResult<List<Product>> GetAll()
        {
            //iş kodları
            if (DateTime.Now.Hour == 22) //sistem saatini verir
            {
                //hergün sistem saati 22 olduğunda ürün listelemeyi kapatmak istiyoruz
                return new ErrorDataResult();
            }
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), true, "ürünler listelendi");
        }
        public IDataResult<Product> GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }
        public IDataResult<List<Product>>  GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

      
        public IDataResult<List<Product>> GeyByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }

       
    }
}

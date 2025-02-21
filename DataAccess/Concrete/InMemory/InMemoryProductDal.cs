﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; //Class'ın içinde ama metodların dışında tanımladığımız için, bunlara o class için global değişken adı veriliyor. _ ile başlayanlar genelde globaldir.
        public InMemoryProductDal() //Direkt classın ismiyle gelen metod = Constructor adını alır. class new'lenince bir defa çalışır.
        {
            //Sanki bir veritabanından geliyormuş gibi memoryde veri oluşturuyoruz
            //Oracle, Sql Server, Postgres, MongoDb, vb... olabilir InMemory yerine
            _products = new List<Product> {
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
                new Product{ProductId=2, CategoryId=1, ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
                new Product{ProductId=3, CategoryId=2, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Klavye", UnitPrice=150, UnitsInStock=65},
                new Product{ProductId=5, CategoryId=2, ProductName="Fare", UnitPrice=85, UnitsInStock=1}
            }; // Heap'te 5 adet adres var.
        }
        public void Add(Product product)
        {
            _products.Add(product); // yukarıda tanımlanan listeye ekliyoruz
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated Query
            //LINQ ile liste bazlı işleri aynen SQL gibi kolayca yapabiliyoruz.

            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId); // LINQ kütüphanesini eklersek foreach'de Id aramak yerine, SingleOrDefault kullanabiliyoruz 

            _products.Remove(productToDelete);
        }
        public List<Product> GetAll()
        {
            return _products;    
        }

        public void Update(Product product) // product, ekrandan gelen data gibi düşünelim.
        {
            //Bana gelen ürün ID'sine sahip olan elemanı kendi listemden (yukarıda global, inMemory'deki sahte veritabanında) bul ki biz onu güncelleyebilelim.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId); // LINQ kütüphanesini eklersek foreach'de Id aramak yerine, SingleOrDefault kullanabiliyoruz 
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList(); //Where yeni bir liste oluşturur ve geri döndürür (Linq metodu)
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}

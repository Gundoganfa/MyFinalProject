using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // c#'da ATTRIBUTE deriz buna, JAVA'da ANNOTATION // Bir class ile ilgili bilgi verme, imzalama yöntemidir.
    public class ProductsController : ControllerBase
    {
        //Loosely coupled // Constructor injection
        //IoC -> asp.net productService görünce gidip containere bakıyor bunun için birşey var mı diye...
        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult Get(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Post(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        //[HttpGet]
        //public List<Product> Get()
        //{
        //    var result = _productService.GetAll();
        //    return result.Data;
        //}

        //-------------------------------
        //[HttpGet]
        //public List<Product> Get()
        //{
        //    IProductService productService = new ProductManager(new EfProductDal());
        //    var result = productService.GetAll();
        //    return result.Data;
        //}
        //-------------------------------
        //[HttpGet]
        //public List<Product> Get()
        //{
        //    return new List<Product>
        //    {
        //        new Product{ProductId = 1, ProductName = "Elma" },
        //        new Product{ProductId = 2, ProductName = "Armut" }
        //    };
        //}
        //-------------------------------
        //[HttpGet]
        //public string Get()
        //{
        //    return "Merhaba";
        //}
        //-------------------------------
    }
}

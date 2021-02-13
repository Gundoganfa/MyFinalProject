RESTFUL --> HTTP

Bizim uygulmamızı kullanmak isteyecek clientlerin bize ulaşacağı istekleri controllerde yazıyoruz.

MVC ile yazılmış bir web uygulaması düşünün

kodlama.io yazıp entera bastığınızda ilk olarak controller karşılıyor.

RESTFUL mimarilerde View katmanı yoktur daha basittir. 

ATTRIBUTE (ANNOTATION)

[ApiController] // c#'da ATTRIBUTE deriz buna, JAVA'da ANNOTATION
public class ProductsController : ControllerBase
{
}

--------------------
productService referansı yok malesef, bu şekilde yazdığımızda api/products altından erişmeye çalıştığımızda hata veriyor.
Bunu çözmek için "IoC = Inversion of Control" kullanıyoruz.

IProductService _productService;
public ProductsController(IProductService productService)
{
    _productService = productService;
}
        
[HttpGet]
public List<Product> Get()
{
    var result = _productService.GetAll();
    return result.Data;
}

------------------------------
Startup.cs altında 
Configuration altına şunu ekliyoruz

services.AddSingleton<IProductService,ProductManager>(); 
// Bana arkaplanda bir referans oluşturur. Yani bu kod, IProductService isteği gelirse arka planda ProductManager newler.
//tüm bellekte tek productManager oluşturuyor.
//içerisinde data tutmadığımızda kullanıyoruz. Eğer bir eticarette sepet kullanıyorsak ve sepeti managerda tutuyorsak, her clienttın sepeti birbirine girer. O yüzdan datasız ise singleton kullanıyoruz.

.AddTransient gibi bazı methodlar ise datalı olduğunda kullanılır.


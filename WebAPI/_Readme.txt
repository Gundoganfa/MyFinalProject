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

//Autofac, Ninject, CastleWindsor, StructureMap, LightInject, DryInject --> IoC Container projeleri, builtin IoC Container mimarisi yokken böyle projeler vardı, .NETCore ile Autofac iyi işler çıkarmaya başladı?
//.net'in altyapısı varken niye autofac kullanalım?
//AOP yapacağız da ondan. 

// AOP nedir? Bir metodun önünde, sonunda, hata verdiğinde, vb. çalışan kod parçacıklarını bunun içine yazıyoruz.
// Business içinde business yazılır, loglama yönetimi, validasyon yönetimi vb. business metodlarının içine yazılmamalıdır.
// metodun üzerine [LogAspect] yazar geçersiniz -> loglar
// [Validate] der geçersiniz ->gelen parametreyi kontrol eder, sınır değer vb.
// [RemoveCache] 
// [Transaction] -> Hata olursa geri al
// [Performance] -> Metod çalışması uzarsa uyar, sistem yavaştır
// vb. gibi
// metod üstüne değil class üstüne yazarsanız o class'ın tüm metodlarını loglar. 
//
// Bu olaya AOP deniyor.
// Autofac bize AOP imkanı sunuyor (başkaları da sunuyor olabilir ama biz autofac'i enjekte edeceğiz)


EntityFramework microsoft ürünü
Amaç: Veritabanındaki tabloyu sanki classmış gibi ilişkilendirip, tüm veritabanı operasyonları Linq ile yapabilmemizi sağlamak

EntityFramework bir ORM (Object Relational Mapping)'dir.

NuGet paket yöneticisi üzerinden Microsoft.EntityFramework kurduk, bunun versiyonunu 
bilgisayarda kurulu .Net framework versiyonuna göre seçeriz..

EntityFramework yükleyince DbContext gibi classlar paket halinde geliyor.

OnConfiguring -> projen hangi veritabanı ile ilişkili bilgisini tanımlar.

DbSet -> Veritabanındaki hangi tabloya yazılımda hangi alan denk geliyor

//Linq kodları ile EntityFramework kodları karışmasın diye öğrenmek lazım

Linq
-----
SingleOrDefault
ToList
vb..
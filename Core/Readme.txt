Tüm projelerde kullanılacak kodları bu proje içine yazabiliriz.
Yani Core katmanı benim evrensel katmanım oluyor. Tüm .Net projelerimde kullanabileceğim bir katman haline geliyor.
CORE Katmanı, diğer katmanları referans almaz. Çünkü o zaman diğer katmanlara bağımlı olur ve farklı projelerde kullanılamaz.

Örneğin DataAccess Klasörü, bu isimdeki katmana hizmet edecek yani veri erişiminde kullanılacak kodları içerecek.
	IEntityRepository'yi DataAccess.Abstract içinden alıp Core->DataAccess içine taşıdık.

namespace yapısı
	classları, interface'leri bir isim uzayında tanıtıyoruz ki bu classlara ve interfacelere nerede erişeceğimiz bilelim.
	DataAccess.Abstract'tan alıp buraya kopyalayınca namespacei de Core.DataAccess olarak değiştiriyoruz.

IEntityRepository'yi Core'a taşıyınca IEntity kızıyor bize.

IEntity de aslında bu projeye özel değil, bunu da Core katmanına taşıyabiliriz. 
O yüzden Core.Entities klasörünü ekledim ve Entities içindeki IEntity'yi kesip buraya yapıştırıyorum.

Core.DataAccess.EntityFramework KLASÖRÜ
	Entity Framework için evrensel kod yazacağımız için bu şekilde isimlendirdik.
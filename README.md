# Real Estate Projesi

Bu projede, emlakçıların sahip oldukları mülkleri satılık veya kiralık olarak ekleyebileceği, kullanıcıların ise bu mülkleri inceleyip kiralama veya satın alma işlemlerini gerçekleştirebileceği bir platform geliştirilmiştir. Proje, **ASP.NET Core 8.0** kullanılarak yapılandırılmıştır ve **Web API** ile **MVC** mimarisi üzerine inşa edilmiştir.

## Kullanılan Teknolojiler

### Back-End:
- **ASP.NET Core 8.0**: Hem Web API hem de MVC mimarisi için temel framework.
- **MSSQL**: Tüm mülk ve kullanıcı bilgileri için kullanılan veritabanı.
- **Dapper**: Veritabanı işlemlerinde hafif ve performans odaklı ORM aracı.
- **ASP.NET Web API**: Kullanıcı ve mülk işlemleri için API üzerinden tüm CRUD işlemlerini yönetir.
- **JWT (JSON Web Token)**: Kullanıcı doğrulama ve yetkilendirme işlemleri için kullanılmıştır.
- **SignalR**: Gerçek zamanlı bildirimler ve anlık iletişim sağlamak için.
- **Swagger**: API uç noktalarının dokümantasyonu ve test edilmesi amacıyla kullanılmıştır.

### Front-End:
- **HTML, CSS, JavaScript**: Platformun kullanıcı arayüzünü oluşturmak için kullanılmıştır.
- **Responsive Tasarım**: **Bootstrap** kullanılarak cihaz uyumluluğu sağlanmıştır.
- **Filtreleme ve Arama**: Kullanıcıların mülkleri arayabilmesi için girilen kelime, gayrimenkul türü ve şehir gibi filtreler mevcuttur.

## Proje Özellikleri
- **API Sonuçları**: API katmanı, JSON formatında veri sağlayarak hızlı ve güvenilir veri iletişimi sağlar.
- **Razor Pages ve ViewComponent**: Dinamik içerik yönetimi ve tekrar kullanılabilirliği artırmak için tercih edilmiştir.
- **Mülk Listeleme ve Filtreleme**: Kullanıcıların kriterlerine göre mülkleri arayıp görüntüleyebileceği bir algoritma geliştirilmiştir.
- **Güvenlik ve Yetkilendirme**: Rol bazlı yetkilendirme ve JWT ile kullanıcıların yetkileri sınırlandırılmıştır. Emlakçılar yalnızca kendi mülklerinde işlem yapabilir, kullanıcılar ise kiralama veya satın alma işlemleri gerçekleştirebilir.

## Proje Görüntüleri
![Alt metin](https://github.com/ertanguclu/RealEstate_Dapper_Api/blob/master/images.gif)






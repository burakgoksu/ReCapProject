# ReCapProject

Genel olarak proje katmanlı mimariye uygun şekilde tasarlanıp OOP olarak entity framework kullanılmaktadır.IoC prensibi ve SOLID ilkeleri ile geliştirilmeye devam ediyor. AutoFac ve FluentValidation paketleri kullanılıyor.

Layers
Business:Sunum katmanından gelen bilgileri gerekli koşullara göre işlemek veya denetlemek için oluşturulan Business Katmanıdır. Abstract klasörü soyut nesneleri, Concrete klasörü somut nesneleri tutmak için oluşturulmuştur.Utilities ve ValidationRules klasörlerinde validation işlemlerinin gerçekleştiği classlar mevcuttur.
Core:Bir framework katmanı olan Core Katmanı'nda DataAccess, Entities olmak üzere 2 adet başka katmana iş yapan klasör bulunmaktadır.DataAccess klasörü DataAccess Katmanı ile ilgili nesneleri, Entities klasörü Entities katmanı ile ilgili nesneleri tutmak için oluşturulmuştur. Core katmanının .Net Core ile hiçbir bağlantısı yoktur.Oluşturulan core katmanında ortak kodlar tutulur. Core katmanı ile, kurumsal bir yapıda, alt yapı ekibi ilgilenir.
DataAccess:Veritabanı CRUD işlemleri gerçekleştirmek için oluşturulan Data Access Katmanı'nda Abstract ve Concrete olmak üzere iki adet klasör bulunmaktadır.Abstract klasörü soyut nesneleri, Concrete klasörü somut nesneleri tutmak için oluşturulmuştur.
Entites:Veritabanı nesneleri için oluşturulmuş Entities Katmanı'nda Abstract ve Concrete olmak üzere iki adet klasör oluşturuldu ancak abstract klasörü core katmanına referans vermesi gerektiğinden dolayı core katmanına taşındı(Core katmanı ortak katmandır hiçbir yerden referans alamaz). Abstract klasörü soyut nesneleri, Concrete klasörü somut nesneleri tutmak için oluşturulmuştur.
WebAPI
WebUI:Proje'de Frontend için Angular kullanıldı.

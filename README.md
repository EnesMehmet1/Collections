C#'daki koleksiyon türlerini yakından inceleyebileceğiniz ve referans alabileceğiniz bir proje.
Burada koleksiyonların hızlarının karşılaştırılması gibi durumları, hangi senaryoda hangi koleksiyon türünü kullanmanın mantıklı olduğu gibi bilgileri öğrenebilirsiniz.

Proje dosyalarından önce bu diyagramı inceleyerek mantıksal çıkarım yapabiliriz;
![image](https://github.com/user-attachments/assets/e79a210c-ea0a-421e-a766-b7253794deea)
IEnumarable Interface'i veri üzerinde herhangi bir CRUD işlemine değil sadece sorgulama yapmılmasına olanak sağlar,
ICollection interface'ini implemente eden kolkesiyonlar ise CRUD işlemlerine olanak sağlarken yanı zamanda kalıtım aldığı IEnumarable interface'inin sağladağı olanakları da kullanabilir.
Ilist ve IDictionary İnterface'leri ICollection'ı miras alırlar ve ICollection özelliklerine ek olarak indexleme özelliği barındırırlar.
IQueryable ise ICollection ve IList ile miras bağıntısı olmadan sadece IEnumarable'i miras alır, IEnumarable'dan farklı olarak veritabanı işlemlerinde kullanılması doğrudur, IEnumarable gibi herhangi bir CRUD işlemi yapamazlar.

IENUMARABLE VE IQUERYABLE FARKI
Veritabanı işlemlerinde herhangi bir sorgu gönderip bunu IEnumarable tipinde yapmak isterseniz, öncek veritabanındaki bütün tabla çekilir ve ardından memory'de sorgulama işlemi yapılır,
Ancak bu işlemi IQueryable tipinde yaparsak gönderdiğimiz sorgu bir SQL sorgusuna dönüştürülür ve herhangi bir reaksiyon alma durumunda (ToList(), FirstOrDefault() vb.) SQL sorgusu çalıştırılır ve koleksiyon memory'e yüklenir. Bu da oldukça yüksek bir performans artısı demek. IEnumarable_IQuereble proje başlığından detaylarını ve zaman kıyslamalarını inceleyebilirsiniz.


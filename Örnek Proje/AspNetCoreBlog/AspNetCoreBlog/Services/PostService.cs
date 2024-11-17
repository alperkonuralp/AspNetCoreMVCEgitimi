using AspNetCoreBlog.Models;

namespace AspNetCoreBlog.Services
{
    public class PostService : IPostService
    {
        private static List<Post> _posts = new List<Post>
        {
            new Post
            {
                Id = 1,
                Title = "İlk Blog Yazım",
                Summary = "Blog yazmaya başladığım ilk yazım.",
                Content = """
                ## Giriş

                Merhaba! Bu benim ilk blog yazım. Blog yazmaya başladım ve bu süreçte yaşadıklarımı sizlerle paylaşmak istiyorum.

                ## Blog Yazmanın Keyfi

                Blog yazmak gerçekten çok keyifli bir uğraş. Düşüncelerinizi, deneyimlerinizi ve bilgilerinizi başkalarıyla paylaşmak harika bir his.

                ## İlk Adımlar

                Blog yazmaya başlamak için öncelikle bir konu belirlemelisiniz. Benim konum, blog yazmaya başlama sürecim ve bu süreçte yaşadıklarım.

                ## Yazı Planı

                Yazılarınızı planlamak, blog yazmanın önemli bir parçasıdır. Hangi konuları ele alacağınızı ve bu konuları nasıl işleyeceğinizi önceden belirlemek işinizi kolaylaştırır.

                ## İçerik Oluşturma

                İçerik oluştururken dikkat etmeniz gereken en önemli şey, okuyucularınıza değer katacak bilgiler sunmaktır. Bu sayede blogunuz daha fazla ilgi çekecektir.

                ## Düzenleme ve Yayınlama

                Yazınızı tamamladıktan sonra mutlaka gözden geçirin ve gerekli düzenlemeleri yapın. Ardından yazınızı yayınlayabilirsiniz.

                ## Okuyucu Geri Bildirimleri

                Okuyucularınızdan gelen geri bildirimler, blog yazma sürecinizde size yol gösterecektir. Bu geri bildirimleri dikkate alarak yazılarınızı geliştirebilirsiniz.

                ## Devamlılık

                Blog yazmak süreklilik gerektiren bir uğraştır. Düzenli olarak yazılar yayınlamak, blogunuzun takipçi kitlesini artıracaktır.

                ## Sonuç

                Blog yazmak, hem kendinizi ifade etmenin hem de başkalarına faydalı olmanın harika bir yoludur. İlk blog yazımda bu süreci sizlerle paylaşmak istedim. Umarım siz de blog yazmaya başlarsınız!

                ## Teşekkürler

                Bu yazıyı okuduğunuz için teşekkür ederim. Bir sonraki yazımda görüşmek üzere!
                """,
                Author = "Ahmet Yılmaz",
                PublishDateTime = DateTimeOffset.Now.AddDays(-4)
            },


            new Post
            {
                Id = 2,
                Title = "C# ile Programlama",
                Summary = "C# programlama dili hakkında temel bilgiler.",
                Content = """
                ## Giriş

                C# (C Sharp), Microsoft tarafından geliştirilen, modern, nesne yönelimli bir programlama dilidir. C# dilini öğrenmek, yazılım geliştirme kariyerinizde size büyük avantajlar sağlayabilir. Bu yazıda, C# dilinin temellerini ve nasıl kullanılacağını öğreneceksiniz.

                ## C# Dilinin Temel Özellikleri

                C# dili, aşağıdaki temel özelliklere sahiptir:

                - **Nesne Yönelimli Programlama (OOP)**: C# dili, nesne yönelimli programlama prensiplerini destekler. Bu sayede, kodunuzu daha modüler ve yeniden kullanılabilir hale getirebilirsiniz.
                - **Tip Güvenliği**: C# dili, tip güvenliğini sağlar. Bu, değişkenlerin ve nesnelerin belirli türlerde olmasını zorunlu kılar ve hataların önlenmesine yardımcı olur.
                - **Çöp Toplama (Garbage Collection)**: C# dili, bellek yönetimini otomatik olarak yapar. Bu sayede, bellek sızıntılarını önleyebilir ve performansı artırabilirsiniz.
                - **Zengin Kütüphane Desteği**: C# dili, .NET kütüphaneleri ile birlikte gelir. Bu kütüphaneler, çeşitli işlevleri kolayca gerçekleştirebilmenizi sağlar.

                ## C# ile İlk Programınızı Yazma

                C# dilinde ilk programınızı yazmak için aşağıdaki adımları izleyebilirsiniz:

                1. **Visual Studio'yu İndirin ve Kurun**: C# dilinde program yazmak için Visual Studio IDE'yi kullanabilirsiniz. Visual Studio'yu [buradan](https://visualstudio.microsoft.com/) indirebilirsiniz.
                2. **Yeni Bir Proje Oluşturun**: Visual Studio'yu açın ve yeni bir C# projesi oluşturun. Konsol uygulaması seçeneğini tercih edebilirsiniz.
                3. **Kodunuzu Yazın**: Aşağıdaki örnek kodu projenize ekleyin:

                ```csharp
                using System;

                namespace HelloWorld
                {
                    class Program
                    {
                        static void Main(string[] args)
                        {
                            Console.WriteLine("Merhaba, Dünya!");
                        }
                    }
                }
                ```
    
                4. **Projeyi Çalıştırın**: Projeyi çalıştırarak "Merhaba, Dünya!" çıktısını görebilirsiniz.

                ## Değişkenler ve Veri Türleri

                C# dilinde değişkenler ve veri türleri, programlama sürecinde önemli bir rol oynar. Aşağıda, C# dilinde yaygın olarak kullanılan bazı veri türleri ve değişken tanımlamaları bulunmaktadır:

                - **int**: Tam sayı veri türü. Örnek: `int sayi = 10;`
                - **double**: Ondalıklı sayı veri türü. Örnek: `double pi = 3.14;`
                - **string**: Metin veri türü. Örnek: `string ad = "Ahmet";`
                - **bool**: Mantıksal veri türü. Örnek: `bool dogruMu = true;`

                ## Koşul İfadeleri

                C# dilinde koşul ifadeleri, belirli koşullara göre kodun çalışmasını sağlar. Aşağıda, if-else koşul ifadesine bir örnek bulunmaktadır:

                ```csharp
                int sayi = 10;

                if (sayi > 5)
                {
                    Console.WriteLine("Sayı 5'ten büyüktür.");
                }
                else
                {
                    Console.WriteLine("Sayı 5'ten küçük veya eşittir.");
                }
                ```
    
                ## Döngüler

                C# dilinde döngüler, belirli bir kod bloğunun tekrar tekrar çalışmasını sağlar. Aşağıda, for döngüsüne bir örnek bulunmaktadır:
    
                ```csharp
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Döngü sayısı: " + i);
                }
                ```
    
            
                ## Sonuç

                Bu yazıda, C# dilinin temellerini ve nasıl kullanılacağını öğrendiniz. C# dilini öğrenmek, yazılım geliştirme kariyerinizde size büyük avantajlar sağlayabilir. Daha fazla bilgi ve ileri seviye konular için C# dökümantasyonunu inceleyebilirsiniz.

                """,
                Author = "Mehmet Kaya",
                PublishDateTime = DateTimeOffset.Now.AddDays(-3)
            },
            new Post
            {
                Id = 3,
                Title = "ASP.NET Core Nedir?",
                Summary = "ASP.NET Core hakkında detaylı bir rehber.",
                Content = "Bu yazıda ASP.NET Core'un ne olduğunu ve nasıl kullanılacağını anlatacağım.",
                Author = "Ayşe Demir",
                PublishDateTime = DateTimeOffset.Now.AddDays(-2)
            },
            new Post
            {
                Id = 4,
                Title = "Yazılım Mühendisliği",
                Summary = "Yazılım mühendisliği ve kariyer fırsatları.",
                Content = "Bu yazıda yazılım mühendisliği mesleği ve bu alandaki kariyer fırsatları hakkında bilgi vereceğim.",
                Author = "Fatma Çelik",
                PublishDateTime = DateTimeOffset.Now.AddDays(-1)
            },
            new Post
            {
                Id = 5,
                Title = "Veritabanı Yönetimi",
                Summary = "Veritabanı yönetimi ve SQL hakkında bilgiler.",
                Content = "Bu yazıda veritabanı yönetiminin temelleri ve SQL kullanımı hakkında bilgi edineceksiniz.",
                Author = "Ali Vural",
                PublishDateTime = DateTimeOffset.Now
            }
        };

        public List<Post> GetAll()
        {
            return _posts;
        }

        public Post? GetById(int id)
        {
            return _posts.Find(x => x.Id == id);
        }
    }
}

using AspNetCoreBlog.Models; // Blog uygulamasının modellerini kullanmak için
using System.Globalization;

namespace AspNetCoreBlog.Services
{
    // Post işlemleri için hizmet sınıfı
    public class PostService : IPostService
    {
        // İngilizce kültür bilgisini tanımlar (tarih ve saat formatları için)
        private static readonly CultureInfo CultureEn = new CultureInfo("en-US");

        // Tüm blog gönderilerini depolayan statik bir liste
        private static readonly List<Post> _posts = new List<Post>
        {
            new Post
            {
                Id = 1,
                Title = "İlk Blog Yazım", // Gönderinin başlığı
                Summary = "Blog yazmaya başladığım ilk yazım.", // Gönderinin özeti
                Content = "~/BlogPostContents/P_1.md", // Gönderi içeriğinin bulunduğu dosya yolu
                Author = "Ahmet Yılmaz", // Gönderinin yazarı
                PublishDateTime = DateTimeOffset.Parse("2024-02-15T03:45:56.812+0300", CultureEn, DateTimeStyles.AssumeUniversal) // Yayınlanma tarihi ve saati
            },
            new Post
            {
                Id = 2,
                Title = "C# ile Programlama",
                Summary = "C# programlama dili hakkında temel bilgiler.",
                Content = "~/BlogPostContents/P_2.md",
                Author = "Mehmet Kaya",
                PublishDateTime = DateTimeOffset.Parse("2024-02-28T23:54:12.812+0300", CultureEn, DateTimeStyles.AssumeUniversal)
            },
            new Post
            {
                Id = 3,
                Title = "ASP.NET Core Nedir?",
                Summary = "ASP.NET Core hakkında detaylı bir rehber.",
                Content = "~/BlogPostContents/P_3.md",
                Author = "Ayşe Demir",
                PublishDateTime = DateTimeOffset.Parse("2024-03-16T10:27:48.812+0300", CultureEn, DateTimeStyles.AssumeUniversal)
            },
            new Post
            {
                Id = 4,
                Title = "Yazılım Mühendisliği",
                Summary = "Yazılım mühendisliği ve kariyer fırsatları.",
                Content = "~/BlogPostContents/P_4.md",
                Author = "Fatma Çelik",
                PublishDateTime = DateTimeOffset.Parse("2024-04-10T08:00:49.812+0300", CultureEn, DateTimeStyles.AssumeUniversal)
            },
            new Post
            {
                Id = 5,
                Title = "Veritabanı Yönetimi",
                Summary = "Veritabanı yönetimi ve SQL hakkında bilgiler.",
                Content = "~/BlogPostContents/P_5.md",
                Author = "Ali Vural",
                PublishDateTime = DateTimeOffset.Parse("2024-04-10T14:37:57.812+0300", CultureEn, DateTimeStyles.AssumeUniversal)
            },
            new Post
            {
                Id = 6,
                Title = "Bulut Bilişim Nedir?",
                Summary = "Bulut bilişim hakkında temel bilgiler.",
                Content = "~/BlogPostContents/P_6.md",
                Author = "Esra Karaca",
                PublishDateTime = DateTimeOffset.Parse("2024-05-01T19:34:21.812+0300", CultureEn, DateTimeStyles.AssumeUniversal)
            },
            new Post
            {
                Id = 7,
                Title = "Makine Öğrenmesi",
                Summary = "Makine öğrenmesi ve yapay zeka hakkında bilgiler.",
                Content = "~/BlogPostContents/P_7.md",
                Author = "Mustafa Arslan",
                PublishDateTime = DateTimeOffset.Parse("2024-05-31T14:30:27.812+0300", CultureEn, DateTimeStyles.AssumeUniversal)
            },
            new Post
            {
                Id = 8,
                Title = "Web Geliştirme Temelleri",
                Summary = "HTML, CSS ve JavaScript ile web geliştirme.",
                Content = "~/BlogPostContents/P_8.md",
                Author = "Zeynep Gül",
                PublishDateTime = DateTimeOffset.Parse("2024-07-20T14:56:30.812+0300", CultureEn, DateTimeStyles.AssumeUniversal)
            },
            new Post
            {
                Id = 9,
                Title = "API Tasarımı",
                Summary = "RESTful API tasarımı hakkında ipuçları.",
                Content = "~/BlogPostContents/P_9.md",
                Author = "Hakan Demir",
                PublishDateTime = DateTimeOffset.Parse("2024-07-27T23:16:27.812+0300", CultureEn, DateTimeStyles.AssumeUniversal)
            },
            new Post
            {
                Id = 10,
                Title = "Test Otomasyonu",
                Summary = "Yazılım test otomasyonu hakkında bir rehber.",
                Content = "~/BlogPostContents/P_10.md",
                Author = "Emel Öztürk",
                PublishDateTime = DateTimeOffset.Parse("2024-10-07T19:09:53.812+0300", CultureEn, DateTimeStyles.AssumeUniversal)
            },
            new Post
            {
                Id = 11,
                Title = "Siber Güvenlik",
                Summary = "Siber güvenlikte temel prensipler.",
                Content = "~/BlogPostContents/P_11.md",
                Author = "Burak Akın",
                PublishDateTime = DateTimeOffset.Parse("2024-11-05T04:07:17.812+0300", CultureEn, DateTimeStyles.AssumeUniversal)
            }
        };

        public Task CreateAsync(Post post)
        {
            var maxId = _posts.Max(x => x.Id); // En büyük ID'yi alır
            post.Id = maxId + 1; // Yeni ID'yi belirler
            _posts.Add(post); // Yeni gönderiyi listeye ekler
            return Task.CompletedTask; // Görevi tamamlar
        }

        public Task EditAsync(Post post)
        {
            var p = _posts.Find(x => x.Id == post.Id); // ID'ye göre gönderiyi bulur
            if (object.ReferenceEquals(p, post)) // Gönderi referansları aynıysa
            {
                return Task.CompletedTask; // Görevi tamamlar
            }
            p.Title = post.Title; // Başlığı günceller
            p.Summary = post.Summary; // Özeti günceller
            p.Content = post.Content; // İçeriği günceller
            p.Author = post.Author; // Yazarı günceller
            p.PublishDateTime = post.PublishDateTime; // Yayınlanma tarihini günceller
            return Task.CompletedTask; // Görevi tamamlar
        }


        // Tüm gönderileri yayınlanma tarihine göre azalan sırada döner
        public List<Post> GetAll()
        {
            return _posts
                        .OrderByDescending(x => x.PublishDateTime) // Gönderileri yayınlanma tarihine göre sırala
                        .ToList(); // Sonuçları liste olarak döndür
        }

        // Belirli bir ID'ye sahip gönderiyi bulur
        public Post? GetById(int id)
        {
            return _posts.Find(x => x.Id == id); // ID'ye göre gönderiyi bul
        }
    }
}
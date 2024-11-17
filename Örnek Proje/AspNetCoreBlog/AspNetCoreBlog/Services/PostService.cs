using AspNetCoreBlog.Models;
using System.Globalization;

namespace AspNetCoreBlog.Services
{
    public class PostService : IPostService
    {
        private static readonly CultureInfo CultureEn = new CultureInfo("en-US");

        private static readonly List<Post> _posts = new List<Post>
        {
            new Post
            {
                Id = 1,
                Title = "İlk Blog Yazım",
                Summary = "Blog yazmaya başladığım ilk yazım.",
                Content = "~/BlogPostContents/P_1.md",
                Author = "Ahmet Yılmaz",
                PublishDateTime = DateTimeOffset.Parse("2024-02-15T03:45:56.812+0300", CultureEn, DateTimeStyles.AssumeUniversal)
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
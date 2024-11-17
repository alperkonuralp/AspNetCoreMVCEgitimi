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
                Content = "Bu benim ilk blog yazım. Blog yazmaya başladım! Bu yazıda blog yazmanın ne kadar keyifli olduğundan bahsedeceğim.",
                Author = "Ahmet Yılmaz",
                PublishDateTime = DateTimeOffset.Now.AddDays(-4)
            },
            new Post
            {
                Id = 2,
                Title = "C# ile Programlama",
                Summary = "C# programlama dili hakkında temel bilgiler.",
                Content = "Bu yazıda C# dilinin temellerini ve nasıl kullanılacağını öğreneceksiniz.",
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

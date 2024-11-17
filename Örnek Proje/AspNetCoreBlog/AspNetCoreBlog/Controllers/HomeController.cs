using AspNetCoreBlog.Models; // Blog uygulamasýnýn modellerini kullanmak için
using AspNetCoreBlog.Services; // Blog servislerini kullanmak için
using Microsoft.AspNetCore.Mvc; // ASP.NET Core MVC özelliklerini kullanmak için
using System.Diagnostics; // Hata ayýklama ve izleme için

namespace AspNetCoreBlog.Controllers
{
    // Ana rota için denetleyici sýnýfý
    [Route("")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; // Günlük kaydý için logger
        private readonly IPostService _postService; // Post servislerini kullanmak için

        // HomeController yapýcýsý: logger ve post servisini enjekte eder
        public HomeController(ILogger<HomeController> logger, IPostService postService)
        {
            _logger = logger;
            _postService = postService;
        }

        // Ana sayfa isteðini karþýlayan GET metodu
        [HttpGet("")]
        public IActionResult Index()
        {
            // Ýlk sayfa verilerini alýr
            PostListModelDto posts = GetDataForPage(1);

            // Görünüme post verilerini gönderir
            return View(posts);
        }

        // Belirli bir sayfa isteðini karþýlayan GET metodu
        [HttpGet("page/{pageIndex:int}")]
        public IActionResult Page(int pageIndex)
        {
            // Model durumunu kontrol eder
            if (!ModelState.IsValid)
            {
                // Model geçersizse 400 Bad Request döner
                return BadRequest(ModelState);
            }

            // Ýstenen sayfanýn verilerini alýr
            PostListModelDto posts = GetDataForPage(pageIndex);

            // Görünüme post verilerini gönderir
            return View(posts);
        }

        // Belirli bir sayfanýn verilerini almak için yardýmcý metot
        private PostListModelDto GetDataForPage(int pageIndex)
        {
            // Tüm postlarý alýr
            var posts = _postService.GetAll();

            // Post listesi modelini baþlatýr
            var result = new PostListModelDto
            {
                PageIndex = pageIndex,
                PageSize = 3, // Sayfa baþýna 3 post gösterilir
                PostCount = 0,
                PagePosts = new List<PostListDto>()
            };

            // Eðer hiç post yoksa boþ sonuç döner
            if (posts.Count == 0)
            {
                return result;
            }

            // Toplam post sayýsýný ayarlar
            result.PostCount = posts.Count;

            // Ýstenen sayfanýn toplam sayfa sayýsýný aþýp aþmadýðýný kontrol eder
            if (result.PageIndex > result.TotalPageCount
                && (result.PageIndex * result.PageSize) > result.PostCount)
            {
                // Aþýyorsa son sayfaya ayarlar
                result.PageIndex = result.TotalPageCount;
            }

            // Eðer toplam post sayýsý sayfa boyutundan fazlaysa, ilgili sayfanýn postlarýný alýr
            if (result.PostCount >= result.PageSize)
            {
                posts = posts
                    .Skip((result.PageIndex - 1) * result.PageSize) // Ýlgili sayfaya kadar atlar
                    .Take(result.PageSize) // Sayfa baþýna belirlenen sayýda post alýr
                    .ToList();
            }

            // Postlarý DTO nesnelerine dönüþtürür
            result.PagePosts = posts
                .ConvertAll(x => new PostListDto
                {
                    Id = x.Id,
                    Title = x.Title,
                    Summary = x.Summary,
                    Author = x.Author,
                    PublishDateTime = x.PublishDateTime
                });

            // Sonuç modelini döner
            return result;
        }

        // Gizlilik politikasý sayfasýný dönen metot
        public IActionResult Privacy()
        {
            return View();
        }

        // Hata sayfasýný dönen metot, önbelleðe alýnmaz
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Hata modelini oluþturur ve görünümü döner
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}

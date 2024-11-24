using AspNetCoreBlog.Models; // Blog uygulamasının modellerini kullanmak için
using AspNetCoreBlog.Services; // Blog servislerini kullanmak için
using Microsoft.AspNetCore.Mvc; // ASP.NET Core MVC özelliklerini kullanmak için
using System.Diagnostics; // Hata ayıklama ve izleme için

namespace AspNetCoreBlog.Controllers
{
    // Ana rota için denetleyici sınıfı
    [Route("")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; // Günlük kaydı için logger
        private readonly IPostService _postService; // Post servislerini kullanmak için

        // HomeController yapıcısı: logger ve post servisini enjekte eder
        public HomeController(ILogger<HomeController> logger, IPostService postService)
        {
            _logger = logger;
            _postService = postService;
        }

        // Ana sayfa isteğini karşılayan GET metodu
        [HttpGet("")]
        public async Task<IActionResult> Index([FromQuery] bool? isDeleteSucceeded)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (isDeleteSucceeded ?? false)
            {
                ViewBag.IsDeleteSucceeded = true;
            }

            PostListModelViewModel posts = await GetDataForPage(1);
            return View(posts);
        }

        // Belirli bir sayfa isteğini karşılayan GET metodu
        [HttpGet("page/{pageIndex:int}")]
        public async Task<IActionResult> Page(int pageIndex)
        {
            // Model durumunu kontrol eder
            if (!ModelState.IsValid)
            {
                // Model geçersizse 400 Bad Request döner
                return BadRequest(ModelState);
            }

            // İstenen sayfanın verilerini alır
            PostListModelViewModel posts = await GetDataForPage(pageIndex);

            // Görünüme post verilerini gönderir
            return View(posts);
        }

        // Belirli bir sayfanın verilerini almak için yardımcı metot
        private async Task<PostListModelViewModel> GetDataForPage(int pageIndex)
        {
            // Tüm postları alır
            var posts = await _postService.GetAllAsync();

            // Post listesi modelini başlatır
            var result = new PostListModelViewModel
            {
                PageIndex = pageIndex,
                PageSize = 3, // Sayfa başına 3 post gösterilir
                PostCount = 0,
                PagePosts = new List<PostListViewModel>()
            };

            // Eğer hiç post yoksa boş sonuç döner
            if (posts.Count == 0)
            {
                return result;
            }

            // Toplam post sayısını ayarlar
            result.PostCount = posts.Count;

            // İstenen sayfanın toplam sayfa sayısını aşıp aşmadığını kontrol eder
            if (result.PageIndex > result.TotalPageCount
                && (result.PageIndex * result.PageSize) > result.PostCount)
            {
                // Aşıyorsa son sayfaya ayarlar
                result.PageIndex = result.TotalPageCount;
            }

            // Eğer toplam post sayısı sayfa boyutundan fazlaysa, ilgili sayfanın postlarını alır
            if (result.PostCount >= result.PageSize)
            {
                posts = posts
                    .Skip((result.PageIndex - 1) * result.PageSize) // İlgili sayfaya kadar atlar
                    .Take(result.PageSize) // Sayfa başına belirlenen sayıda post alır
                    .ToList();
            }

            // Postları DTO nesnelerine dönüştürür
            result.PagePosts = posts
                .ConvertAll(x => new PostListViewModel
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

        // Gizlilik politikası sayfasını dönen metot
        public IActionResult Privacy()
        {
            return View();
        }

        // Hata sayfasını dönen metot, önbelleğe alınmaz
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Hata modelini oluşturur ve görünümü döner
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
using AspNetCoreBlog.Models; // Blog uygulamas�n�n modellerini kullanmak i�in
using AspNetCoreBlog.Services; // Blog servislerini kullanmak i�in
using Microsoft.AspNetCore.Mvc; // ASP.NET Core MVC �zelliklerini kullanmak i�in
using System.Diagnostics; // Hata ay�klama ve izleme i�in

namespace AspNetCoreBlog.Controllers
{
    // Ana rota i�in denetleyici s�n�f�
    [Route("")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; // G�nl�k kayd� i�in logger
        private readonly IPostService _postService; // Post servislerini kullanmak i�in

        // HomeController yap�c�s�: logger ve post servisini enjekte eder
        public HomeController(ILogger<HomeController> logger, IPostService postService)
        {
            _logger = logger;
            _postService = postService;
        }

        // Ana sayfa iste�ini kar��layan GET metodu
        [HttpGet("")]
        public IActionResult Index()
        {
            // �lk sayfa verilerini al�r
            PostListModelDto posts = GetDataForPage(1);

            // G�r�n�me post verilerini g�nderir
            return View(posts);
        }

        // Belirli bir sayfa iste�ini kar��layan GET metodu
        [HttpGet("page/{pageIndex:int}")]
        public IActionResult Page(int pageIndex)
        {
            // Model durumunu kontrol eder
            if (!ModelState.IsValid)
            {
                // Model ge�ersizse 400 Bad Request d�ner
                return BadRequest(ModelState);
            }

            // �stenen sayfan�n verilerini al�r
            PostListModelDto posts = GetDataForPage(pageIndex);

            // G�r�n�me post verilerini g�nderir
            return View(posts);
        }

        // Belirli bir sayfan�n verilerini almak i�in yard�mc� metot
        private PostListModelDto GetDataForPage(int pageIndex)
        {
            // T�m postlar� al�r
            var posts = _postService.GetAll();

            // Post listesi modelini ba�lat�r
            var result = new PostListModelDto
            {
                PageIndex = pageIndex,
                PageSize = 3, // Sayfa ba��na 3 post g�sterilir
                PostCount = 0,
                PagePosts = new List<PostListDto>()
            };

            // E�er hi� post yoksa bo� sonu� d�ner
            if (posts.Count == 0)
            {
                return result;
            }

            // Toplam post say�s�n� ayarlar
            result.PostCount = posts.Count;

            // �stenen sayfan�n toplam sayfa say�s�n� a��p a�mad���n� kontrol eder
            if (result.PageIndex > result.TotalPageCount
                && (result.PageIndex * result.PageSize) > result.PostCount)
            {
                // A��yorsa son sayfaya ayarlar
                result.PageIndex = result.TotalPageCount;
            }

            // E�er toplam post say�s� sayfa boyutundan fazlaysa, ilgili sayfan�n postlar�n� al�r
            if (result.PostCount >= result.PageSize)
            {
                posts = posts
                    .Skip((result.PageIndex - 1) * result.PageSize) // �lgili sayfaya kadar atlar
                    .Take(result.PageSize) // Sayfa ba��na belirlenen say�da post al�r
                    .ToList();
            }

            // Postlar� DTO nesnelerine d�n��t�r�r
            result.PagePosts = posts
                .ConvertAll(x => new PostListDto
                {
                    Id = x.Id,
                    Title = x.Title,
                    Summary = x.Summary,
                    Author = x.Author,
                    PublishDateTime = x.PublishDateTime
                });

            // Sonu� modelini d�ner
            return result;
        }

        // Gizlilik politikas� sayfas�n� d�nen metot
        public IActionResult Privacy()
        {
            return View();
        }

        // Hata sayfas�n� d�nen metot, �nbelle�e al�nmaz
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Hata modelini olu�turur ve g�r�n�m� d�ner
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}

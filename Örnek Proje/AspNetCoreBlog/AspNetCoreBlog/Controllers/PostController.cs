using AspNetCoreBlog.Models; // Blog uygulamasının modellerini kullanmak için
using AspNetCoreBlog.Services; // Blog servislerini kullanmak için
using Markdig; // Markdown içeriğini HTML'e dönüştürmek için
using Markdig.SyntaxHighlighting;
using Microsoft.AspNetCore.Mvc; // ASP.NET Core MVC özelliklerini kullanmak için

namespace AspNetCoreBlog.Controllers
{
    // Post işlemleri için denetleyici sınıfı
    public class PostController : Controller
    {
        private readonly IPostService _postService; // Post servislerini kullanmak için

        // PostController yapıcısı: post servisini enjekte eder
        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        // Belirli bir postu görüntülemek için Index metodu
        public IActionResult Index(int id)
        {
            // Model durumunu kontrol eder
            if (!ModelState.IsValid)
            {
                // Model geçersizse 400 Bad Request döner
                return BadRequest(ModelState);
            }

            // Verilen ID'ye sahip postu alır
            var post = _postService.GetById(id);

            // Post bulunamazsa 404 Not Found döner
            if (post == null)
            {
                return NotFound();
            }

            var content = post.Content;

            // İçerik bir dosya yolu ile başlıyorsa, dosya içeriğini okur
            if (content.StartsWith("~/"))
            {
                // Dosya yolundan ilk iki karakteri kaldırır ve dosyayı okur
                content = System.IO.File.ReadAllText(content.Substring(2));
            }

            var pipeline = new MarkdownPipelineBuilder()
                .UseAdvancedExtensions()
                .UseSyntaxHighlighting() // Sözdizimi vurgulama genişletmesi
                .Build();

            // Markdown içeriğini HTML'e dönüştürür ve PostDetailDto oluşturur
            return View(new PostDetailViewModel
            {
                Id = post.Id, // Postun ID'si
                Title = post.Title, // Postun başlığı
                Summary = post.Summary, // Postun özeti
                HtmlContent = Markdown.ToHtml(content, pipeline), // Markdown'dan dönüştürülmüş HTML içeriği
                Author = post.Author, // Postun yazarı
                PublishDateTime = post.PublishDateTime // Yayınlanma tarihi ve saati
            });
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromForm] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Post silme işlemini gerçekleştirir
            var result = await _postService.DeleteAsync(id);

            // Post silme işlemi başarılıysa, 200 OK döner
            return RedirectToAction("Index", "Home", new { isDeleteSucceeded = result });
        }
    }
}
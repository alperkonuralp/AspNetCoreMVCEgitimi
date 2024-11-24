using AspNetCoreBlog.Models;
using AspNetCoreBlog.Services;
using Markdig;
using Markdig.SyntaxHighlighting;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBlog.Controllers
{
    [Route("[controller]")]
    public class PostEditController : Controller
    {
        private readonly IPostService _postService;

        public PostEditController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet("{id}")]
        public IActionResult Index([FromRoute] int id, [FromQuery] bool? isSuccess)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if(isSuccess.HasValue && isSuccess.Value)
            {
                ViewBag.IsSuccess = true;
            }

            var post = _postService.GetById(id);

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

            content = Markdown.ToHtml(content, pipeline);

            return View(new PostEditViewModel
            {
                Id = post.Id,
                Title = post.Title,
                Summary = post.Summary,
                Content = content,
                Author = post.Author,
                PublishDateTime = post.PublishDateTime
            });
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromForm] PostEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var post = _postService.GetById(model.Id);

            if (post == null)
            {
                return NotFound();
            }

            // Convert HTML to Markdown
            var converter = new ReverseMarkdown.Converter();
            var markdownContent = converter.Convert(model.Content);

            post.Title = model.Title;
            post.Summary = model.Summary;
            post.Content = markdownContent;
            post.Author = model.Author;

            await _postService.EditAsync(post);

            return RedirectToAction("Index", new { id = post.Id, isSuccess = true });
        }
    }
}
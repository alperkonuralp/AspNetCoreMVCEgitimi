using AspNetCoreBlog.Models;
using AspNetCoreBlog.Services;
using Markdig;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBlog.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        public IActionResult Index(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var post = _postService.GetById(id);

            if (post == null)
            {
                return NotFound();
            }

            var content = post.Content;
            if (content.StartsWith("~/"))
            {
                content = System.IO.File.ReadAllText(content.Substring(2));
            }

            return View(new PostDetailDto
            {
                Id = post.Id,
                Title = post.Title,
                Summary = post.Summary,
                HtmlContent = Markdown.ToHtml(content),
                Author = post.Author,
                PublishDateTime = post.PublishDateTime
            });
        }
    }
}
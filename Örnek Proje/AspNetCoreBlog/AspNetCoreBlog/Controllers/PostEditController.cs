using AspNetCoreBlog.Models;
using AspNetCoreBlog.Services;
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
        public IActionResult Index([FromRoute] int id)
        {
            var post = _postService.GetById(id);

            if (post == null)
            {
                return NotFound();
            }

            return View(new PostEditViewModel
            {
                Id = post.Id,
                Title = post.Title,
                Summary = post.Summary,
                Content = post.Content,
                Author = post.Author,
                PublishDateTime = post.PublishDateTime
            });
        }

    }
}

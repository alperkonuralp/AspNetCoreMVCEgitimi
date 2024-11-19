using AspNetCoreBlog.Models;
using AspNetCoreBlog.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBlog.Controllers
{
    [Route("[controller]")]
    public class PostCreateController : Controller
    {
        private readonly IPostService _postService;

        public PostCreateController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromForm] PostCreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var post = new Post
            {
                Title = model.Title,
                Summary = model.Summary,
                Content = model.Content,
                Author = model.Author,
                PublishDateTime = DateTimeOffset.Now,
            };

            await _postService.CreateAsync(post);

            return RedirectToAction("Index", "Home");
        }
    }
}

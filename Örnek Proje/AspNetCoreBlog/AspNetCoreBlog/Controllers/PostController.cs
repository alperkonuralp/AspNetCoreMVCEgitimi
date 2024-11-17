using AspNetCoreBlog.Services;
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

        //[HttpGet("{id}")]
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

            return View(post);
        }
    }
}

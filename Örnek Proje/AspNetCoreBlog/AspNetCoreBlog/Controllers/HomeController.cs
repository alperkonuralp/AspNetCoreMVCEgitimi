using AspNetCoreBlog.Models;
using AspNetCoreBlog.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCoreBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPostService _postService;

        public HomeController(ILogger<HomeController> logger, IPostService postService)
        {
            _logger = logger;
            _postService = postService;
        }

        public IActionResult Index()
        {
            var posts = _postService.GetAll()
                .ConvertAll(x => new PostListDto
                {
                    Id = x.Id,
                    Title = x.Title,
                    Summary = x.Summary,
                    Author = x.Author,
                    PublishDateTime = x.PublishDateTime
                });

            return View(posts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

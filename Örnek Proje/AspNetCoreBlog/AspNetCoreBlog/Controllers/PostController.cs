using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBlog.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

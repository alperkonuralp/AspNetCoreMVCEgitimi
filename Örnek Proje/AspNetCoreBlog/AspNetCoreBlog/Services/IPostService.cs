using AspNetCoreBlog.Models;

namespace AspNetCoreBlog.Services
{
    public interface IPostService
    {
        List<Post> GetAll();
        Post? GetById(int id);
    }
}
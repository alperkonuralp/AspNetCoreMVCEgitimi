using AspNetCoreBlog.Models;

namespace AspNetCoreBlog.Services
{
    public interface IPostService
    {
        Task CreateAsync(Post post);
        List<Post> GetAll();
        Post? GetById(int id);
    }
}
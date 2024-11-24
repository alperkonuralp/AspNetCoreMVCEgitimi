using AspNetCoreBlog.Data;
using AspNetCoreBlog.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace AspNetCoreBlog.Services
{
    // Post işlemleri için hizmet sınıfı
    public class PostService : IPostService
    {
        private readonly BlogDbContext _context;

        public PostService(BlogDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Post post)
        {
            await _context.Posts.AddAsync(post);
            await _context.SaveChangesAsync();
        }

        public async Task EditAsync(Post post)
        {
            var existingPost = await _context.Posts.FindAsync(post.Id);
            if (existingPost == null)
            {
                throw new InvalidOperationException("Post not found");
            }

            existingPost.Title = post.Title;
            existingPost.Summary = post.Summary;
            existingPost.Content = post.Content;
            existingPost.Author = post.Author;
            // existingPost.PublishDateTime = post.PublishDateTime; // PublishDateTime should not be updated

            _context.Posts.Update(existingPost);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return false;
            }

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
            return true;
        }

        // Tüm gönderileri yayınlanma tarihine göre azalan sırada döner
        public async Task<List<Post>> GetAllAsync()
        {
            return await _context.Posts
                        .OrderByDescending(x => x.PublishDateTime)
                        .ToListAsync();
        }

        // Belirli bir ID'ye sahip gönderiyi bulur
        public async Task<Post?> GetByIdAsync(int id)
        {
            return await _context.Posts.FindAsync(id);
        }
    }
}
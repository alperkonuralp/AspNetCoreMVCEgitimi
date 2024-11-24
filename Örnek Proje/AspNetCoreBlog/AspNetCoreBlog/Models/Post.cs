using System.ComponentModel.DataAnnotations;

namespace AspNetCoreBlog.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(512)]
        public string? Summary { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        [StringLength(255)]
        public string Author { get; set; }

        [Required]
        public DateTimeOffset PublishDateTime { get; set; } = DateTimeOffset.Now;
    }
}

using System.ComponentModel.DataAnnotations;

namespace AspNetCoreBlog.Models
{
    public class PostCreateViewModel
    {
        [Required(ErrorMessage = "Başlık zorunludur.")]
        [StringLength(255)]
        [Display(Name = "Başlık")]
        public string Title { get; set; }

        [StringLength(511)]
        [Display(Name = "Özet")]
        public string? Summary { get; set; }

        [Required(ErrorMessage = "İçerik zorunludur.")]
        [Display(Name = "İçerik (Markdown)")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Yazar zorunludur.")]
        [StringLength(255)]
        [Display(Name = "Yazar")]
        public string Author { get; set; }
    }
}
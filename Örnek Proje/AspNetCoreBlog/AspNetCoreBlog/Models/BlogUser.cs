using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreBlog.Models
{
    public class BlogUser : IdentityUser
    {
        [StringLength(127)]
        public string? FullName { get; set; }
    }
}
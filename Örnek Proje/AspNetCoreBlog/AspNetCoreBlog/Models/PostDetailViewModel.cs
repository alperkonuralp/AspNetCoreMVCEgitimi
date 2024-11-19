namespace AspNetCoreBlog.Models
{
    public class PostDetailViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string HtmlContent { get; set; }

        public string Author { get; set; }

        public DateTimeOffset PublishDateTime { get; set; }
    }
}

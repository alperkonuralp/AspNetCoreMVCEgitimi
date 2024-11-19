namespace AspNetCoreBlog.Models
{
    public class PostListModelViewModel
    {
        public int PostCount { get; set; }

        public int PageIndex { get; set; } = 1;

        public int PageSize { get; set; } = 3;

        public int TotalPageCount => (PostCount + PageSize - 1) / PageSize;

        public IEnumerable<PostListViewModel> PagePosts { get; set; }

    }
}

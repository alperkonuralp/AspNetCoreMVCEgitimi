namespace AspNetCoreBlog.Models
{
    public class PostListModelDto
    {
        public int PostCount { get; set; }

        public int PageIndex { get; set; } = 1;

        public int PageSize { get; set; } = 3;

        public int TotalPageCount => (PostCount + PageSize - 1) / PageSize;

        public IEnumerable<PostListDto> PagePosts { get; set; }

    }
}

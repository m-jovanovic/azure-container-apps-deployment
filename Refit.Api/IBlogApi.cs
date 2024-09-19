using Refit;

public interface IBlogApi
{
    [Get("/posts")]
    Task<List<Post>> GetPostsAsync([Query] int? userId);

    [Get("/posts/{id}")]
    Task<Post> GetPostAsync(int id);

    [Get("/posts/{id}/comments")]
    Task<List<Comment>> GetPostCommentsAsync(int id);

    [Post("/posts")]
    Task<Post> CreatePostAsync([Body] Post post);

    [Put("/posts/{id}")]
    Task<Post> UpdatePostAsync(int id, [Body] Post post);

    [Delete("/posts/{id}")]
    Task DeletePostAsync(int id);
}

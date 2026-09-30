


Post.CreatePost("First Post", "This is the first post", 1);
Post.CreatePost("Second Post", "This is the second post", 2);
Post.CreatePost("Third Post", "This is the third post", 1);


foreach (var post in Post.GetPosts())
{
    System.Console.WriteLine($"Id: {post.Id}, Title: {post.Title}, Description: {post.Description}, CategoryId: {post.CategoryId}");
}

var postsByCategory = Post.GetPostsByCategory(2);
foreach (var post in postsByCategory)
{
    Console.WriteLine($"Id: {post.Id}, Title: {post.Title}, Description: {post.Description}, CategoryId: {post.CategoryId}");
}



using System.Data.Common;

public class Post
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int CategoryId { get; set; }
    public static List<Post> posts = [];
    static int cnt = 1;
    public static void CreatePost(string title , string desc , int categoryId)
    {
        var post = new Post()
        {
            Id = cnt,
            Title = title,
            Description = desc,
            CategoryId = categoryId
        };
        posts.Add(post);
        cnt++;
    }
    public static List<Post> GetPosts()
    {
        return posts;
    }
    public static Post GetPostById(int id)
    {
        foreach (var item in posts)
        {
            if(item.Id == id)
            {
                return item;
            }
        }

        return null;
    }
    public static Post GetPostByName(string name)
    {
        foreach (var item in posts)
        {
            if(item.Title == name)
            {
                return item;
            }
        }

        return null;
    }
    public static void DeletePost(int id)
    {
        foreach (var item in posts)
        {
            if(item.Id == id)
            {
                posts.Remove(item);
                return;
            }
        }
        System.Console.WriteLine("Post not found");
    }
    public static List<Post> GetPostsByCategory(int categoryId)
    {   
        List<Post> result = [];
        foreach (var item in posts)
        {
            if (item.CategoryId == categoryId)
            {
                result.Add(item);
            }
        }
        return result;
    }
}
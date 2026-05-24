using BlogPostMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogPostMVC.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            var posts = new List<Post>
            {
                new Post
                {
                    Id = 1,
                    Title = "My First Blog Post",
                    Content = "This is the content of my first post.",
                    Author = "Josh Lester Gruta"
                },
                new Post
                {
                    Id = 2,
                    Title = "Learning ASP.NET Core MVC",
                    Content = "MVC stands for Model, View, and Controller.",
                    Author = "Josh Lester Gruta"
                },
                new Post
                {
                    Id = 3,
                    Title = "Building a Blog App",
                    Content = "This is a simple blog application using mock data.",
                    Author = "Josh Lester Gruta"
                }
            };

            return View(posts);
        }

        public IActionResult Details(int id)
        {
            var posts = new List<Post>
            {
                new Post
                {
                    Id = 1,
                    Title = "My First Blog Post",
                    Content = "This is the content of my first post.",
                    Author = "Josh Lester Gruta"
                },
                new Post
                {
                    Id = 2,
                    Title = "Learning ASP.NET Core MVC",
                    Content = "MVC stands for Model, View, and Controller.",
                    Author = "Josh Lester Gruta"
                },
                new Post
                {
                    Id = 3,
                    Title = "Building a Blog App",
                    Content = "This is a simple blog application using mock data.",
                    Author = "Josh Lester Camposano Gruta"
                }
            };

            var post = posts.FirstOrDefault(p => p.Id == id);

            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Biale_Buciki.Models;

namespace Biale_Buciki.Controllers;

public class HomeController : Controller {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger) {
        _logger = logger;
    }

    public IActionResult Index() {
        var posts = GenerateDummyPosts();
        ViewBag.Posts = posts;
        return View();
    }

    
    public IActionResult NewPost() {
        return View();
    }
        
        
    public IActionResult Privacy() {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    
    
    /// TO WSZYSTKO TRZEBA PRZENIESC DALEJ:
    ///
    public static List<Post> GenerateDummyPosts()
    {
        var posts = new List<Post>
        {
            new Post("1", "Post 1", "Description for Post 1"),
            new Post("2", "Post 2", "Description for Post 2"),
            new Post("3", "Post 3", "Description for Post 3"),
            new Post("4", "Post 4", "Description for Post 4"),
            new Post("5", "Post 5", "Description for Post 5")
        };

        return posts;
    }
    
    
    
}
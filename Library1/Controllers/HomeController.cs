
using Library1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static List<Book> books = new List<Book>
        {
            new Book
            {
                Id = 1,
                Name = "Apple",
                Author = "Stiv Jobs",
                Price = 500000
            },
            new Book
            {
                Id = 2,
                Name = "Dunyo Ishlari",
                Author = "H.To'xtaboyev",
                Price = 30000
            },
           
        };
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(books);
        }
        public IActionResult Book()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Book book)
        {
            books.Add(book);
            return RedirectToAction("index");
        }
    }
}
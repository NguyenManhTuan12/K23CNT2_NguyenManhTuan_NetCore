using Microsoft.AspNetCore.Mvc;
using Nmtlesson04.Models;

namespace Nmtlesson04.Controllers
{
    public class NmtBookController : Controller
    {
        protected NmtBooks book = new NmtBooks();

        public IActionResult NmtIndex()
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            var books = book.GetBookList();
            return View(books);
        }
    }
}

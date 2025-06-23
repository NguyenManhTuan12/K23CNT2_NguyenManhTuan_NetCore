using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Nmtlesson04.Models
{
    public class NmtBooks : Controller
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float price { get; set; }
        public int TotaPage { get; set; }
        public string Summary { get; set; }

        public List<NmtBooks> GetBookList()
        {
            List<NmtBooks> books = new List<NmtBooks>()
            {
                new NmtBooks()
                {
                    Title = "ApspNe",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/image/book01.jpg",
                    price = 12000,
                    TotaPage = 100,
                    Summary = ""
                },
                new NmtBooks()
                {
                    Title = "ApspNe",
                    AuthorId = 2,
                    GenreId = 2,
                    Image = "/image/book01.jpg",
                    price = 12000,
                    TotaPage = 100,
                    Summary = ""
                },
                new NmtBooks()
                {
                    Title = "ApspNe",
                    AuthorId = 3,
                    GenreId = 3,
                    Image = "/image/book03.jpg",
                    price = 12000,
                    TotaPage = 100,
                    Summary = ""
                },
            };
            return books;
        }

        public NmtBooks GetBookById(int id)
        {
            NmtBooks book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }

        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem{ Value = "1", Text = "Nam Cao" },
            new SelectListItem{ Value = "2", Text = "Ngo Tat To" },
            new SelectListItem{ Value = "3", Text = "Adam Khoom" },
        };

        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem{ Value = "1", Text = "Truyen tranh" },
            new SelectListItem{ Value = "2", Text = "Van hoc duong dai" },
            new SelectListItem{ Value = "3", Text = "Phat hoc pho thong" },
        };
    }
}

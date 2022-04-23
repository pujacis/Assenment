using Assenment.Data;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Assessment1.Controllers
{
    [Authorize(Roles = "Book Owner")]
    public class BooksController : Controller
    {
        TrainingDBContext db = new TrainingDBContext();
        [HttpGet]
        [Authorize(Roles = "Peopl,Book Owner")]
        public IActionResult GetBooks()
        {
            List<PujaBook> booklist =db.PujaBooks.ToList();

            return View(booklist);
        }
        [HttpGet]
        [Authorize(Roles = "Book Seller,Book Owner")]
        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(PujaBook book)
        {
            db.PujaBooks.Add(book);
            db.SaveChanges();
            if (book!=null)
            {
                return RedirectToAction("GetBooks");
            }
            return View(book);
        }
        [HttpGet]
        public IActionResult UpdateBook(int Id)
        { 
            var book =db.PujaBooks.Where(model=>model.Id==Id).FirstOrDefault();

            return View(book);
        }
        [HttpPost]
        public IActionResult UpdateBook(PujaBook book)
        {
            var bok = db.PujaBooks.Where(model => model.Id == book.Id).FirstOrDefault();
            if(bok!=null)
            {
                bok.Id= book.Id;
                bok.BookName= book.BookName;
                bok.Author= book.Author;
                bok.Price= book.Price;
                bok.ReleaseDate= book.ReleaseDate;
                bok.Discount= book.Discount;
                bok.Genre= book.Genre;
                db.SaveChanges();
                if (book != null)
                {
                    return RedirectToAction("GetBooks");
                }
            }
            return View(book);
        }
         public IActionResult DeleteBook(int id)
        {
            var book =db.PujaBooks.Where(model=>model.Id==id).FirstOrDefault(); 
            db.Entry(book).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
            if (book != null)
            {
                return RedirectToAction("GetBooks");
            }
            return View();
        }
        public IActionResult BookDetails(int Id)
        {
            var book = db.PujaBooks.Where(model => model.Id == Id).FirstOrDefault();

            return View(book);
        }

    }
}

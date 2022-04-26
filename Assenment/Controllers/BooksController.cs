using Assenment.Data;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Assessment1.Controllers
{
    //[Authorize(Roles = "Book Owner,Super Admin,Peopl")]
    [Authorize]
    public class BooksController : Controller
    {
        TrainingDBContext db = new TrainingDBContext();
        [HttpGet]
        [Authorize]
        public IActionResult GetBooks()
        {
            List<PujaBook> booklist = db.PujaBooks.ToList();

            return View(booklist);
        }
        [HttpGet]
        [Authorize(Roles = "Book Seller,Book Owner,Super Admin")]
        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Book Seller,Book Owner,Super Admin")]
        public IActionResult AddBooks(PujaBook book)
        {
            db.PujaBooks.Add(book);
            db.SaveChanges();
            if (book != null)
            {
                return RedirectToAction("GetBooks");
            }
            return View(book);
        }
        [HttpGet]
        [Authorize(Roles = "Book Seller,Book Owner,Super Admin")]
        public IActionResult UpdateBook(int Id)
        {
            var book = db.PujaBooks.Where(model => model.Id == Id).FirstOrDefault();

            return View(book);
        }
        [HttpPost]
        [Authorize(Roles = "Book Seller,Book Owner,Super Admin")]
        public IActionResult UpdateBook(PujaBook book)
        {
            var bok = db.PujaBooks.Where(model => model.Id == book.Id).FirstOrDefault();
            if (bok != null)
            {
                bok.Id = book.Id;
                bok.BookName = book.BookName;
                bok.Author = book.Author;
                bok.Price = book.Price;
                bok.ReleaseDate = book.ReleaseDate;
                bok.Discount = book.Discount;
                bok.Genre = book.Genre;
                db.SaveChanges();
                if (book != null)
                {
                    return RedirectToAction("GetBooks");
                }
            }
            return View(book);
        }
        [Authorize(Roles = "Book Seller,Book Owner,Super Admin")]
        public IActionResult DeleteBook(int id)
        {
            var book = db.PujaBooks.Where(model => model.Id == id).FirstOrDefault();
            db.Entry(book).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
            if (book != null)
            {
                return RedirectToAction("GetBooks");
            }
            return View();
        }
        [Authorize(Roles = "Book Seller,Book Owner,Super Admin,Peopl")]
        public IActionResult BookDetails(int Id)
        {
            var book = db.PujaBooks.Where(model => model.Id == Id).FirstOrDefault();

            return View(book);
        }
        public JsonResult GetBookList()
        {
            return Json(db.PujaBooks.ToList());
        }
        public JsonResult AddBook(PujaBook book)
        {
            string status = "success";
            try
            {
                db.PujaBooks.Add(book);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                status = ex.Message;
            }
            return Json(status);

        }
    }
}

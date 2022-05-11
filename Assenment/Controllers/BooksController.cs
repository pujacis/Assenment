using Assenment.Data;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Assessment1.Controllers
{
    //[Authorize(Roles = "Book Owner")]
    public class BooksController : Controller
    {
        TrainingDBContext db = new TrainingDBContext();
        [HttpGet]
        //[Authorize(Roles = "Peopl,Book Owner")]
        public IActionResult GetBooks()
        {
            List<PujaBook> booklist =db.PujaBooks.ToList();

            return View(booklist);
        }
        [HttpGet]
        //[Authorize(Roles = "Book Seller,Book Owner")]
        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(PujaBook book)
        {
            var files = HttpContext.Request.Form.Files;
            string path = Directory.GetCurrentDirectory();


            foreach (var Image in files)
            {
                if (Image != null && Image.Length > 0)
                {
                    var file = Image;
                    // string p = "~/wwwroot/Shared/Uploads/img";
                    // var uploads = System.IO.Path.Combine(p, "Uploads\\img");
                    var uploads = path + "\\wwwroot\\Uploads\\File";


                    if (!Directory.Exists(uploads))
                    {
                        Directory.CreateDirectory(uploads);
                    }


                    if (file.Length > 0)
                    {
                        var supportedTypes = new[] { "jpg", "png", "jpeg", "gif" };
                        var fileExt = System.IO.Path.GetExtension(file.FileName).Substring(1);
                        book.FileName = file.FileName;

                        if (!supportedTypes.Contains(fileExt))
                        {
                            //ErrorMessage = "File Extension Is InValid - Only Upload WORD/PDF/EXCEL/TXT File";
                            //return ErrorMessage;
                        }
                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                        book.FilePath = "\\wwwroot\\Uploads\\File\\" + fileName;
                        using (var fileStream = new System.IO.FileStream(System.IO.Path.Combine(uploads, fileName), FileMode.Create))
                        {
                            //file.ContentType
                            file.CopyToAsync(fileStream);
                            // cm.Logo = fileName;
                            book.UploadFile = System.IO.Path.Combine(uploads, fileName);
                        }


                    }
                }
            }
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

        public ActionResult DownloadDocument(int Id)
        {
            string path = Directory.GetCurrentDirectory();
            var book = db.PujaBooks.Where(model => model.Id == Id).FirstOrDefault();
            var filePath = path + book.FilePath;
                byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);

                return File(fileBytes, "application/force-download", book.FileName);
            

           
        }

    }
}

using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Book
    {
        public Book()
        {
            BookGalleries = new HashSet<BookGallery>();
        }

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public int LanguageId { get; set; }
        public int TotalPages { get; set; }
        public string? CoverImageUrl { get; set; }
        public string? BookPdfUrl { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual Language Language { get; set; } = null!;
        public virtual ICollection<BookGallery> BookGalleries { get; set; }
    }
}

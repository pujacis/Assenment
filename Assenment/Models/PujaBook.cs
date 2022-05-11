using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class PujaBook
    {
        public int Id { get; set; }
        public string? BookName { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? Price { get; set; }
        public int? Discount { get; set; }
        public byte[]? UploadFile { get; set; }
    }
}

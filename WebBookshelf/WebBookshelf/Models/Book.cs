using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBookshelf.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookWriterName { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}

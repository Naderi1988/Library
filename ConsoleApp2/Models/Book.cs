using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string BookTranslator { get; set; }
        public string BookPublisher { get; set; }
        public string BookSubjects { get; set; }
        public int BookDate { get; set; }
        public string Booklink { get; set; }
    }
}

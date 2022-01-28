using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("LibConStr")
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }



    }
}

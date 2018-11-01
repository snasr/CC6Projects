using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Cars.Business.Models
{
    public class BooksDB : DbContext
    {
        public BooksDB() : base("name=BooksDB")
        {
        }

        public DbSet<Book> Books { get; set; }
    }

    public class Book
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Author { get; set; }
        public virtual string ISBN { get; set; }
    }
}

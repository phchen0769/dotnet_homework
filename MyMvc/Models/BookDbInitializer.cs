using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyMvc.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = " 标题 1 ", Author = " 作者 1 ", Price = 250 });
            db.Books.Add(new Book { Name = " 标题 2 ", Author = " 作者 2 ", Price = 200 });
            db.Books.Add(new Book { Name = " 标题 3 ", Author = " 作者 3 ", Price = 150 });
            base.Seed(db);
        }
    }
}

usingSystem;
usingSystem.Collections.Generic;
usingSystem.Linq;
usingSystem.Web;
usingSystem.Data.Entity;
namespaceBookStore.Models
{
    publicclass BookDbInitializer : DropCreateDatabaseAlways<BookContext>
{
        protectedoverride void Seed(BookContext db)
        {
            db.Books.Add(newBook { Name = " Назва 1 " , Author = " Автор 1 " , Price = 250 });
            db.Books.Add(newBook { Name = " Назва 2", Author = " Автор 2", Price = 200});
            db.Books.Add(newBook { Name = " Назва 3", Author = " Автор 3", Price = 150});
            base.Seed(db);
        }
    }
}
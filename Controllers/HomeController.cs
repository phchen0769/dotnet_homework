usingSystem;
usingSystem.Collections.Generic;
usingSystem.Linq;
usingSystem.Web;
usingSystem.Web.Mvc;
usingBookStore.Models;
namespaceBookStore.Controllers
{
    publicclass HomeController : Controller
{
        // створюємо контекст даних
        BookContext db = newBookContext();
        publicActionResult Index()
        {
            // отримуємо з бд усі об'єкти Book
            IEnumerable<Book> books = db.Books;
            // передаємо всі отримані об'єкти в динамічну властивість Books в ViewBag
            ViewBag.Books = books;
            // Повертаємо представлення
            returnView();
        }
    }

    [HttpGet]
    publicActionResult Buy(int id)
    {
        ViewBag.BookId = id;
        returnView();
    }
    [HttpPost]
    publicstring Buy(Purchase purchase)
    {
        purchase.Date = DateTime.Now;
        // додаємо інформацію про покупку до бази даних
        db.Purchases.Add(purchase);
        // зберігаємо у бд усі зміни
        db.SaveChanges();
        return "Спасибі," + purchase.Person + ", за покупку!";
    }
}
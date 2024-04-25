using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using MyMvc.Models;
namespace MyMvc.Controllers
{
    public class HomeController : Controller
    {
        // 创建数据上下文
        BookContext db = new BookContext();
        public ActionResult Index()
        {
            // 从数据库获取所有Book对象
            IEnumerable<Book> books = db.Books;
            // 将获取的所有对象传递到ViewBag的动态属性Books中
            ViewBag.Books = books;
            // 返回视图
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            // 将购买信息添加到数据库中
            db.Purchases.Add(purchase);
            // 保存所有更改到数据库
            db.SaveChanges();
            return "谢谢," + purchase.Person + ", 感谢您的购买!";
        }
    }
}
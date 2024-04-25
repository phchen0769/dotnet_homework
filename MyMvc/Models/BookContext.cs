using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

namespace MyMvc.Models
{
    // 设置数据库连接字符串
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlite("Data Source=myDB.db");
    // }
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}
using System;
namespace MyMvc.Models
{
    public class Purchase
    {
        // 购买ID
        public int PurchaseId { get; set; }
        // 购买人
        public string Person { get; set; }
        // 购买人地址
        public string Address { get; set; }
        //  书本ID
        public int BookId { get; set; }
        // 购买日期
        public DateTime Date { get; set; }
    }
}
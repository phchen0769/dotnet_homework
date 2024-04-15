namespace BookStore.Models
{
    public class Book
    {
        // 书本ID
        public int Id { get; set; }
        // 书本名称
        public string Name { get; set; }
        // 书本作者
        public string Author { get; set; }
        // 书本价格
        public int Price { get; set; }
    }
}
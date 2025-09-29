namespace ECommerceApp.Core.Models
{
    public class Product
    {
        public int Id { get; set; }          // уникальный идентификатор
        public string Name { get; set; }     // название
        public decimal Price { get; set; }   // цена

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Id}: {Name} - {Price}₽";
        }
    }
}

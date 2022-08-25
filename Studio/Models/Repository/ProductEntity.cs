using Dapper.Contrib.Extensions;
using Studio.Models.Enum;

namespace Studio.Models.Repository
{
    [Table("Products")]
    public class ProductEntity
    {
        public ProductEntity(int id, string name, decimal price, decimal costprice, int quantity, CategoryEnum categoryid)
        {
            Id = id;
            Name = name;
            Price = price;
            CostPrice = costprice;
            Quantity = quantity;
            CategoryId = categoryid;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }  

        public int Quantity { get; set; }

        public CategoryEnum CategoryId { get; set; } 

        public decimal CostPrice { get; set; }  
    }
}

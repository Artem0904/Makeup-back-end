using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Image { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public int CategoryId {  get; set; }
        public Category Category { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public ICollection<Order>? Orders { get; set; } = new HashSet<Order>();
    }
}

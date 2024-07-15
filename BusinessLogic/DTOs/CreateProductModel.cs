using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class CreateProductModel
    {
        public string Name { get; set; }
        public string? Image { get; set; }
        public int BrandId { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public int CategoryId { get; set; }
        public int GenderId { get; set; }
    }
}

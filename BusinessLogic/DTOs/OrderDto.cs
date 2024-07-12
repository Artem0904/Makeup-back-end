﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
        public int TotalPrice { get; set; }

    }
}

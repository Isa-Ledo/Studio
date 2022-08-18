﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Models.Repository
{
    [Table("Products")]
    public class ProductEntity
    {
        public ProductEntity(string name, decimal price, int quantity, int categoryid)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            CategoryId = categoryid;
        }

        public ProductEntity() { }

        public int? Id { get; set; }

        public string? Name { get; set; }

        public decimal? Price { get; set; }  

        public int? Quantity { get; set; }

        public int? CategoryId { get; set; } 
    }
}

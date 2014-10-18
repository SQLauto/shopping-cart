using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingStore.Domain.Entities
{
    public class Product
    {

        public int ProductID { get; set; }

        public int CategoryID { get; set; }

        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }
    }
}
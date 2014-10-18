using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ShoppingStore.Domain.Entities;

namespace ShoppingStore.Web.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }

        public PageInfo PageInfo { get; set; }
    }
}
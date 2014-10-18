﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingStore.Domain.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }

        public string Title { get; set; }

        public string ImageUrl { get; set; }
    }
}
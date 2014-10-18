using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ShoppingStore.Domain.Abstract;
using ShoppingStore.Domain.Entities;
using ShoppingStore.Web.Models;

namespace ShoppingStore.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository productRepository)
        {
            this.repository = productRepository;
        }

        public ViewResult List(string categoryID)
        {
            IEnumerable<Product> CateProducts = 
                repository.Products.
                Where(p => categoryID == null || p.CategoryID == int.Parse(categoryID)).
                OrderBy(p => p.ProductID);
            ViewBag.CurrentCategoryID = categoryID;
            return View(CateProducts);
        }


    }
}

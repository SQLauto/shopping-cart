using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ShoppingStore.Domain.Abstract;
using ShoppingStore.Domain.Entities;

namespace ShoppingStore.Web.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository categoryRepo)
        {
            this.categoryRepository = categoryRepo;
        }

        public PartialViewResult CategoryMenu(string categoryID = null)
        {
            ViewBag.SelectedCategoryID = categoryID;

            return PartialView(categoryRepository.Categories);
        }



    }
}

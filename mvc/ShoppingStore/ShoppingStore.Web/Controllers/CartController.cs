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
    public class CartController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 3;


        public CartController(IProductRepository productRepository)
        {
            repository = productRepository;
        }

        public ViewResult Index(Cart cart, int page = 1)
        {
            return View(new CartIndexViewModel
            {
                Cart = new Cart(cart.Lines
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize)
                    .ToList()
                ),
                PageInfo = new PageInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = cart.Lines.Count()
                }
            });
        }

        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }

        [HttpPost]
        public ActionResult AddToCart(Cart cart, int productId, int quantity)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.ProductID == productId);

            if (product != null)
            {
                cart.AddItem(product, quantity);
            }
            return Content("View The Cart (" + cart.ComputeQuantity() + " Products)");
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart, int productId)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.ProductID == productId);

            if (product != null)
            {
                cart.RemoveLine(product);
            }
            return RedirectToAction("Index");
        }

        public ViewResult Checkout()
        {
            return View(new CheckOutDetails());
        }

        [HttpPost]
        public ViewResult Checkout(Cart cart, CheckOutDetails checkOutDetails)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }

            if (ModelState.IsValid)
            {
                return View("Completed");
            }
            else
            {
                return View(checkOutDetails);
            }
        }

    }
}

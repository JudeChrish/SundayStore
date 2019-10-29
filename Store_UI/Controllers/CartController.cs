using Store_Domain;
using Store_Domain.Entities;
using Store_Domain.Service;
using Store_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store_UI.Controllers
{
    public class CartController : Controller
    {
        IStoreService _storeService = null;
        public CartController(IStoreService storeService)
        {
            _storeService = storeService;
        }

        public RedirectToRouteResult AddToCart(Cart cart, int AlbumId, string returnUrl)
        {
           Album album =  _storeService.GetAllAlbums().FirstOrDefault(a => a.AlbumId == AlbumId);
            
            if (album != null)
            {
                //Cart CartSession = (Cart)Session["Cart"];
                //CartHelper.GetCart(CartSession).AddItem(product, 1);
                cart.AddItem(album, 1);
            }
            ViewBag.Title = "Shopping Store: Your Cart";
            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToRouteResult RemoveFromCart(Cart cart, int AlbumId, string returnUrl)
        {
            Album album = _storeService.GetAllAlbums().FirstOrDefault(w => w.AlbumId == AlbumId);
            if (album != null)
            {
                //Cart cart = (Cart)Session["Cart"];
                //CartHelper.GetCart(cart).RemoveItem(album, 1);
                cart.RemoveItem(album);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public ViewResult Checkout(Cart cart)
        {
            cart.ClearTheCart();
            return View();
        }

        public ViewResult Index(Cart cart, string ReturnUrl)
        {
            
            //Cart cart = GetCart();
            CartIndexViewModel indexViewModel = new CartIndexViewModel();
            indexViewModel.cart = cart;
            indexViewModel.ReturnUlr = ReturnUrl;

            return View(indexViewModel);
        }

        public Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
    }
}
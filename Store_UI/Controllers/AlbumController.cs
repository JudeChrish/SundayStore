using Store_Domain.Service;
using Store_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store_UI.Controllers
{
    public class AlbumController : Controller
    {
        IStoreService _storeService = null;
        public AlbumController(IStoreService storeService)
        {
            _storeService = storeService;
        }
        // GET: Album
        public ViewResult AllAlbums()
        {
            var albums = _storeService.GetAllAlbums();
            ProductListViewModel productListViewModel = new ProductListViewModel()
            {
                ShowingAlbums = albums
            };

            return View(productListViewModel);
        }
    }
}
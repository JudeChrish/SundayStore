using Newtonsoft.Json;
using Store_Domain;
using Store_Domain.Service;
using Store_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace Store_UI.Controllers
{
    public class AlbumController : Controller
    {
        IStoreService _storeService = null;
        private string BaseURI = WebConfigurationManager.AppSettings["BaseUri"];

        public AlbumController(IStoreService storeService)
        {
            _storeService = storeService;
        }
        //// GET: Album details from web api
        public async Task<ViewResult> AllAlbums()
        {
            ProductListViewModel productListViewModel = new ProductListViewModel();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseURI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage responseMessage = await client.GetAsync("album/albums");
                if (responseMessage.IsSuccessStatusCode)
                {
                    var data = await responseMessage.Content.ReadAsStringAsync();
                    productListViewModel.ShowingAlbums = JsonConvert.DeserializeObject<List<Album>>(data);
                }
            }

            return View(productListViewModel);
        }
       
        //// GET: Album details from database
        //public ViewResult AllAlbums()
        //{
        //    var albums = _storeService.GetAllAlbums();
        //    ProductListViewModel productListViewModel = new ProductListViewModel()
        //    {
        //        ShowingAlbums = albums
        //    };

        //    return View(productListViewModel);
        //}
    }
}
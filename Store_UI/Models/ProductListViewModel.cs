using Store_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store_UI.Models
{
    public class ProductListViewModel
    {
        public IEnumerable<Album> ShowingAlbums { get; set; }
    }
}
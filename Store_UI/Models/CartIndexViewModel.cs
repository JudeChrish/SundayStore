using Store_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store_UI.Models
{
    public class CartIndexViewModel
    {
        public Cart cart { get; set; }
        public string ReturnUlr { get; set; }
    }
}
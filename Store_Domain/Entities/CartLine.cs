using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Domain.Entities
{
    public class CartLine
    {
        public Album album { get; set; }
        public int Quantity { get; set; }
    }
}

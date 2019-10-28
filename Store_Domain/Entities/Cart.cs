using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Domain.Entities
{
    public class Cart
    {
        public List<CartLine> LineCollection = new List<CartLine>();
        private CartLine Line;

        public void AddItem(Album Selected_Album, int Selected_Quantity)
        {
            Line = LineCollection.FirstOrDefault(f => f.album.AlbumId == Selected_Album.AlbumId);

            if (Line == null)
            {
                LineCollection.Add(new CartLine { album = Selected_Album, Quantity = Selected_Quantity });
            }
            else
            {
                Line.Quantity += Selected_Quantity;
            }
        }

        public void RemoveItem(Album Selected_Album)
        {
            LineCollection.RemoveAll(r => r.album.AlbumId == Selected_Album.AlbumId);
        }

        public decimal ComputeTotalValue()
        {
            return LineCollection.Sum(p => p.album.AlbumPrice * p.Quantity);
        }

        public IEnumerable<CartLine> GetAllItems()
        {
            return LineCollection;
        }

        public void ClearTheCart()
        {
            LineCollection.Clear();
        }
    }
}

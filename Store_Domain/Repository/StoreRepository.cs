using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store_Domain.Repository
{
    public class StoreRepository : IStoreRepository
    {
        private StoreDBContext storeDBContext = new StoreDBContext();
        public List<Album> GetAllActiveAlbums()
        {
            return storeDBContext.albums.Where(a => a.IsAcitve).ToList();
        }
    }
}

using Store_Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Domain.Service
{
    public class StoreService : IStoreService
    {
        private IStoreRepository _storeRepository = null;
        public StoreService(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }
        public List<Album> GetAllAlbums()
        {
            return _storeRepository.GetAllActiveAlbums();
        }
    }
}

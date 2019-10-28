using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Domain.Repository
{
    public interface IStoreRepository
    {
        List<Album> GetAllActiveAlbums();
    }
}

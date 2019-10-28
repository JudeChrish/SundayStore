using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Domain.Service
{
    public interface IStoreService
    {
        List<Album> GetAllAlbums();
    }
}

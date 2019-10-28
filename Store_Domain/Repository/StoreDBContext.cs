using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Store_Domain.Repository
{
    public class StoreDBContext : DbContext
    {
        public DbSet<Album> albums { get; set; }
    }
}

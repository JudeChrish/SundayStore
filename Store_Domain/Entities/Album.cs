using System.ComponentModel.DataAnnotations.Schema;

namespace Store_Domain
{
    [Table("Album", Schema = "Store")]
    public class Album
    {
            public int AlbumId { get; set; }
            public string AlbumName { get; set; }
            public string AlbumDescription { get; set; }
            public string AlbumCategory { get; set; }
            public decimal AlbumPrice { get; set; }
            public bool IsAcitve { get; set; }
    }
}

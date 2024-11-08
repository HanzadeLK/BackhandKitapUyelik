using System.ComponentModel.DataAnnotations;

namespace BHPKitapUyelik.Models
{
    public class Kitap
    {
            public int KitapId { get; set; }
            [Required]
            [StringLength(80)]
            public string? Ad { get; set; }
            public string? Yazar { get; set; }
            [Range(1, int.MaxValue)]
            public int SayfaSayisi { get; set; }
            public string? YayinEvi { get; set; }
            public int BasimYili { get; set; }

    }
}

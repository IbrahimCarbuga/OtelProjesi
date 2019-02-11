using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes
{
    [Table("Yorumlar")]
    public class Yorum: DbObjectHD
    {
        public Yorum(Musteri musteri, string yorumBasligi, string yorumIcerigi)
        {
            this.musteri = musteri;
            YorumBasligi = yorumBasligi;
            YorumIcerigi = yorumIcerigi;
            Yildizlar = new List<Yildiz>();
        }

        public Musteri musteri { get; set; }
        [Required]
        [MaxLength(50)]
        public string YorumBasligi { get; set; }
        [Required]
        [MaxLength(1000)]
        public string YorumIcerigi { get; set; }
        public List<Yildiz> Yildizlar { get; set; }
        public override string ToString()
        {
            return YorumBasligi;
        }
    }
}

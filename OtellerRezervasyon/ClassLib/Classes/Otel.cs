using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes
{
    [Table("Oteller")]
    public class Otel : DbObjectHD
    {
        public Otel(int yildizSayisi, string adi, Il ıller, string vergiNo, string resmiAdi, string aciklama)
        {
            YildizSayisi = yildizSayisi;
            Adi = adi;
            Iller = ıller;
            VergiNo = vergiNo;
            ResmiAdi = resmiAdi;
            Aciklama = aciklama;
            Yorumlar = new List<Yorum>();
            Yildizlar = new List<Yildiz>();
        }
        public Otel()
        {

        }

        public int YildizSayisi { get; set; }
        [Required]
        [MaxLength(50)]
        public string Adi { get; set; }
        public Il Iller { get; set; }
        [Required]
        [MaxLength(50)]
        public string VergiNo { get; set; }
        [Required]
        [MaxLength(50)]
        public string ResmiAdi { get; set; }
        [Required]
        [MaxLength(50)]
        public string Aciklama { get; set; }
        public List<Yorum> Yorumlar { get; set; }
        public List<Yildiz> Yildizlar { get; set; }
        public override string ToString()
        {
            return Adi;
        }

    }
}

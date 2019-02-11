using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes
{
    [Table("Musteriler")]
    public class Musteri: DbObjectHD
    {
        public Musteri(string adi, string soyadi, string sifre, string kullaniciAdi, string telefon, string eMail, string tcNo)
        {
            Adi = adi;
            Soyadi = soyadi;
            Sifre = sifre;
            KullaniciAdi = kullaniciAdi;
            Telefon = telefon;
            EMail = eMail;
            TcNo = tcNo;
        }
        public Musteri()
        {

        }
        [Required]
        [MaxLength(50)]
        public string Adi { get; set; }
        [Required]
        [MaxLength(50)]
        public string Soyadi { get; set; }
        [Required]
        [MaxLength(30)]
        public string Sifre { get; set; }
        [Required]
        [MaxLength(30)]
        public string KullaniciAdi { get; set; }
        [Required]
        [MaxLength(11)]
        public string Telefon { get; set; }
        [Required]
        [MaxLength(50)]
        public string EMail { get; set; }
        [Required]
        [MaxLength(11)]
        public string TcNo { get; set; }
        public override string ToString()
        {
            return Adi;
        }

    }
}

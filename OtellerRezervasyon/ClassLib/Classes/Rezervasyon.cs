using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes
{
    [Table("Rezervasyonlar")]
    public class Rezervasyon : DbObjectHD
    {
        public Rezervasyon(Musteri musteri, Oda oda, int kisiSayisi, DateTime checkInDate, DateTime checkOutDate, OdemeZamani odemeZamani)
        {
            this.musteri = musteri;
            this.oda = oda;
            KisiSayisi = kisiSayisi;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            this.odemeZamani = odemeZamani;
        }
        public Rezervasyon()
        {

        }

        public Musteri musteri { get; set; }
        public Oda oda { get; set; }
        public int KisiSayisi { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public OdemeZamani odemeZamani { get; set; }
        public override string ToString()
        {
            return KisiSayisi.ToString();
        }
    }
}

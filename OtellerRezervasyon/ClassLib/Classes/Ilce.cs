using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes
{
    [Table("Ilceler")]
    public class Ilce : DbObjectHD
    {
        public Ilce(string ılceAdi)
        {
            IlceAdi = ılceAdi;
            Mahalleler = new List<Mahalle>();
        }
        [Required]
        [MaxLength(50)]
        public string IlceAdi { get; set; }
        public List<Mahalle> Mahalleler { get; set; }

        public override string ToString()
        {
            return IlceAdi;
        }
        public Ilce()
        {

        }
    }
}

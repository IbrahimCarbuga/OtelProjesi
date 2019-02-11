using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes
{
    [Table("Ozellikler")]
    public class Ozellik: DbObjectHD
    {
        public Ozellik(string ozellikAdi)
        {
            OzellikAdi = ozellikAdi;
        }
        public Ozellik()
        {

        }
        [Required]
        [MaxLength(50)]
        public string OzellikAdi { get; set; }
        public override string ToString()
        {
            return OzellikAdi;
        }
    }
}

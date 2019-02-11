using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes
{
    [Table("Mahalleler")]
    public class Mahalle : DbObjectHD
    {
        [Required]
        [MaxLength(50)]
        public string MahalleAdi{ get; set; }
        public override string ToString()
        {
            return MahalleAdi;
        }

    }
}

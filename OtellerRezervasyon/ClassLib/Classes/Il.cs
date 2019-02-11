using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes
{
    [Table("Iller")]
  public class Il : DbObjectHD
    {
        [Required]
        [MaxLength(50)]
        public string IlAdi { get; set; }
        public List<Ilce> Ilçeler { get; set; }
        public Il(string ilAdi)
        {
            IlAdi = ilAdi;
            Ilçeler = new List<Ilce>();
        }

        public override string ToString()
        {
            return IlAdi;
        }
        public Il()
        {

        }
    }
}

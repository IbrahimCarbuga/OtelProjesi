using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes
{
    [Table("Yildizlar")]
    public class Yildiz : DbObjectHD
    {
        public Yildiz(int begenmeSayisi, int begenmemeSayisi)
        {
            BegenmeSayisi = begenmeSayisi;
            BegenmemeSayisi = begenmemeSayisi;
        }
        public Yildiz()
        {

        }

        public int BegenmeSayisi { get; set; }
        public int BegenmemeSayisi { get; set; }
        public override string ToString()
        {
            return BegenmemeSayisi.ToString();
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes
{
    [Table("Odalar")]
    public class Oda: DbObjectHD
    {
        public Oda(Otel otel, bool bosMu, OdaTipi odaTipi, double fiyat,string odaNumarasi)
        {
            this.otel = otel;
            BosMu = true;
            this.odaTipi = odaTipi;
            Fiyat = fiyat;
            OdaNumarasi = odaNumarasi;
        }
        public Oda()
        {
            BosMu = true;
        }

        public Otel otel { get; set; }
        public bool BosMu { get; set; }
        public OdaTipi odaTipi { get; set; }
        public double Fiyat { get; set; }
        [Required]
        [MaxLength(5)]
        public string OdaNumarasi { get; set; }
        public override string ToString()
        {
            return Fiyat.ToString();
        }
    }
}

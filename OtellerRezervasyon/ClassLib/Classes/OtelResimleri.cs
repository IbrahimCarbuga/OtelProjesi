using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes
{
    [Table("OtelResimleri")]
    public class OtelResimleri : DbObjectHD
    {
        public OtelResimleri(Otel otel, byte resimler)
        {
            this.otel = otel;
            Resimler = resimler;
        }

        public Otel otel { get; set; }
        public byte Resimler { get; set; }
        public OtelResimleri()
        {

        }
        public override string ToString()
        {
            return otel.Adi;
        }
    }
}

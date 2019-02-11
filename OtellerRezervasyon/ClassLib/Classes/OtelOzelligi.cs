using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes
{
    [Table("OtelOzellikleri")]
    public class OtelOzelligi: DbObjectHD
    {
        public OtelOzelligi(Otel otel, Ozellik ozellik)
        {
            this.otel = otel;
            this.ozellik = ozellik;
        }
        public OtelOzelligi()
        {

        }

        public Otel otel { get; set; }
        public Ozellik ozellik { get; set; }
        public override string ToString()
        {
            return  otel.Adi;
        }

    }
}

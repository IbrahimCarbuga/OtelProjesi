using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes
{
    //Her yere yazemak yerine bir yere yazıp kullanmak -> Factory Design Pattern
    public static class DbFactory
    {
        //Birden fazla kez üretilmesini engellemek için ->Singleton
        private static volatile OtelContext _db = null;
        public static OtelContext Db
        {
            get
            {
                if (_db == null)
                {
                    _db = new OtelContext();
                }
                return _db;
            }
        }
        public static volatile OtelCrud<Il> _ilCrud = null;
        public static OtelCrud<Il> IlCrud
        {
            get
            {
                if (_ilCrud == null)
                {
                    _ilCrud = new OtelCrud<Il>(Db, Db.Iller);
                }
                return _ilCrud;
            }
        }
        public static volatile OtelCrud<Ilce> _ilceCrud = null;
        public static OtelCrud<Ilce> IlceCrud
        {
            get
            {
                if (_ilceCrud == null)
                {
                    _ilceCrud = new OtelCrud<Ilce>(Db, Db.Ilceler);
                }
                return _ilceCrud;
            }
        }
        public static volatile OtelCrud<Mahalle> _mahalleCrud = null;
        public static OtelCrud<Mahalle> MahalleCrud
        {
            get
            {
                if (_mahalleCrud == null)
                {
                    _mahalleCrud = new OtelCrud<Mahalle>(Db, Db.Mahalleler);
                }
                return _mahalleCrud;
            }
        }
        public static volatile OtelCrud<Musteri> _musteriCrud = null;
        public static OtelCrud<Musteri> MusteriCrud
        {
            get
            {
                if (_musteriCrud == null)
                {
                    _musteriCrud = new OtelCrud<Musteri>(Db, Db.Musteriler);
                }
                return _musteriCrud;
            }
        }
        public static volatile OtelCrud<Oda> _odaCrud = null;
        public static OtelCrud<Oda> OdaCrud
        {
            get
            {
                if (_odaCrud == null)
                {
                    _odaCrud = new OtelCrud<Oda>(Db, Db.Odalar);
                }
                return _odaCrud;
            }
        }
        public static volatile OtelCrud<Otel> _otelCrud = null;
        public static OtelCrud<Otel> OtelCrud
        {
            get
            {
                if (_otelCrud == null)
                {
                    _otelCrud = new OtelCrud<Otel>(Db, Db.Oteller);
                }
                return _otelCrud;
            }
        }
        public static volatile OtelCrud<OtelOzelligi> _otelOzelligiCrud = null;
        public static OtelCrud<OtelOzelligi> OtelOzelligiCrud
        {
            get
            {
                if (_otelOzelligiCrud == null)
                {
                    _otelOzelligiCrud = new OtelCrud<OtelOzelligi>(Db, Db.OtelOzellikleri);
                }
                return _otelOzelligiCrud;
            }
        }
        public static volatile OtelCrud<OtelResimleri> _otelResimleriCrud = null;
        public static OtelCrud<OtelResimleri> OtelResimleriCrud
        {
            get
            {
                if (_otelResimleriCrud == null)
                {
                    _otelResimleriCrud = new OtelCrud<OtelResimleri>(Db, Db.OtelResimleri);
                }
                return _otelResimleriCrud;
            }
        }
        public static volatile OtelCrud<Ozellik> _ozellikCrud = null;
        public static OtelCrud<Ozellik> OzellikCrud
        {
            get
            {
                if (_ozellikCrud == null)
                {
                    _ozellikCrud = new OtelCrud<Ozellik>(Db, Db.Ozellikler);
                }
                return _ozellikCrud;
            }
        }
        public static volatile OtelCrud<Rezervasyon> _rezervasyonCrud = null;
        public static OtelCrud<Rezervasyon> RezervasyonCrud
        {
            get
            {
                if (_rezervasyonCrud == null)
                {
                    _rezervasyonCrud = new OtelCrud<Rezervasyon>(Db, Db.Rezervasyonlar);
                }
                return _rezervasyonCrud;
            }
        }
        public static volatile OtelCrud<Yildiz> _yildizCrud = null;
        public static OtelCrud<Yildiz> YildizCrud
        {
            get
            {
                if (_yildizCrud == null)
                {
                    _yildizCrud = new OtelCrud<Yildiz>(Db, Db.Yildizlar);
                }
                return _yildizCrud;
            }
        }
        public static volatile OtelCrud<Yorum> _yorumCrud = null;
        public static OtelCrud<Yorum> YorumCrud
        {
            get
            {
                if (_yorumCrud == null)
                {
                    _yorumCrud = new OtelCrud<Yorum>(Db, Db.Yorumlar);
                }
                return _yorumCrud;
            }
        }



    }
}

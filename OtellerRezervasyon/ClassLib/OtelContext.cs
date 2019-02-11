namespace ClassLib
{
    using ClassLib.Classes;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class OtelContext : DbContext
    {
        // Your context has been configured to use a 'OtelContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ClassLib.OtelContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'OtelContext' 
        // connection string in the application configuration file.
        public OtelContext()
            : base("name=OtelContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Il> Iller { get; set; }
        public virtual DbSet<Ilce> Ilceler { get; set; }
        public virtual DbSet<Mahalle> Mahalleler { get; set; }
        public virtual DbSet<Musteri> Musteriler { get; set; }
        public virtual DbSet<Oda> Odalar { get; set; }
        public virtual DbSet<Otel> Oteller { get; set; }
        public virtual DbSet<OtelOzelligi> OtelOzellikleri { get; set; }
        public virtual DbSet<OtelResimleri> OtelResimleri { get; set; }
        public virtual DbSet<Ozellik> Ozellikler { get; set; }
        public virtual DbSet<Rezervasyon> Rezervasyonlar { get; set; }
        public virtual DbSet<Yildiz> Yildizlar { get; set; }
        public virtual DbSet<Yorum> Yorumlar { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
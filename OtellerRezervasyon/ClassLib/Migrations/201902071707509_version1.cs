namespace ClassLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ilces",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        IlceAdi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                        Il_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ils", t => t.Il_Id)
                .Index(t => t.Il_Id);
            
            CreateTable(
                "dbo.Mahalles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        MahalleAdi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                        Ilce_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ilces", t => t.Ilce_Id)
                .Index(t => t.Ilce_Id);
            
            CreateTable(
                "dbo.Ils",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        IlAdi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Adi = c.String(),
                        Soyadi = c.String(),
                        Sifre = c.String(),
                        KullaniciAdi = c.String(),
                        Telefon = c.String(),
                        EMail = c.String(),
                        TcNo = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Odas",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        BosMu = c.Boolean(nullable: false),
                        odaTipi = c.Int(nullable: false),
                        Fiyat = c.Double(nullable: false),
                        OdaNumarasi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                        otel_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Otels", t => t.otel_Id)
                .Index(t => t.otel_Id);
            
            CreateTable(
                "dbo.Otels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        YildizSayisi = c.Int(nullable: false),
                        Adi = c.String(),
                        VergiNo = c.String(),
                        ResmiAdi = c.String(),
                        Aciklama = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                        Iller_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ils", t => t.Iller_Id)
                .Index(t => t.Iller_Id);
            
            CreateTable(
                "dbo.Yildizs",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        BegenmeSayisi = c.Int(nullable: false),
                        BegenmemeSayisi = c.Int(nullable: false),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                        Otel_Id = c.String(maxLength: 128),
                        Yorum_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Otels", t => t.Otel_Id)
                .ForeignKey("dbo.Yorums", t => t.Yorum_Id)
                .Index(t => t.Otel_Id)
                .Index(t => t.Yorum_Id);
            
            CreateTable(
                "dbo.Yorums",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        YorumBasligi = c.String(),
                        YorumIcerigi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                        musteri_Id = c.String(maxLength: 128),
                        Otel_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Musteris", t => t.musteri_Id)
                .ForeignKey("dbo.Otels", t => t.Otel_Id)
                .Index(t => t.musteri_Id)
                .Index(t => t.Otel_Id);
            
            CreateTable(
                "dbo.OtelOzelligis",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                        otel_Id = c.String(maxLength: 128),
                        ozellik_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Otels", t => t.otel_Id)
                .ForeignKey("dbo.Ozelliks", t => t.ozellik_Id)
                .Index(t => t.otel_Id)
                .Index(t => t.ozellik_Id);
            
            CreateTable(
                "dbo.Ozelliks",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OzellikAdi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OtelResimleris",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Resimler = c.Byte(nullable: false),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                        otel_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Otels", t => t.otel_Id)
                .Index(t => t.otel_Id);
            
            CreateTable(
                "dbo.Rezervasyons",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        KisiSayisi = c.Int(nullable: false),
                        CheckInDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        odemeZamani = c.Int(nullable: false),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                        musteri_Id = c.String(maxLength: 128),
                        oda_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Musteris", t => t.musteri_Id)
                .ForeignKey("dbo.Odas", t => t.oda_Id)
                .Index(t => t.musteri_Id)
                .Index(t => t.oda_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rezervasyons", "oda_Id", "dbo.Odas");
            DropForeignKey("dbo.Rezervasyons", "musteri_Id", "dbo.Musteris");
            DropForeignKey("dbo.OtelResimleris", "otel_Id", "dbo.Otels");
            DropForeignKey("dbo.OtelOzelligis", "ozellik_Id", "dbo.Ozelliks");
            DropForeignKey("dbo.OtelOzelligis", "otel_Id", "dbo.Otels");
            DropForeignKey("dbo.Odas", "otel_Id", "dbo.Otels");
            DropForeignKey("dbo.Yorums", "Otel_Id", "dbo.Otels");
            DropForeignKey("dbo.Yildizs", "Yorum_Id", "dbo.Yorums");
            DropForeignKey("dbo.Yorums", "musteri_Id", "dbo.Musteris");
            DropForeignKey("dbo.Yildizs", "Otel_Id", "dbo.Otels");
            DropForeignKey("dbo.Otels", "Iller_Id", "dbo.Ils");
            DropForeignKey("dbo.Ilces", "Il_Id", "dbo.Ils");
            DropForeignKey("dbo.Mahalles", "Ilce_Id", "dbo.Ilces");
            DropIndex("dbo.Rezervasyons", new[] { "oda_Id" });
            DropIndex("dbo.Rezervasyons", new[] { "musteri_Id" });
            DropIndex("dbo.OtelResimleris", new[] { "otel_Id" });
            DropIndex("dbo.OtelOzelligis", new[] { "ozellik_Id" });
            DropIndex("dbo.OtelOzelligis", new[] { "otel_Id" });
            DropIndex("dbo.Yorums", new[] { "Otel_Id" });
            DropIndex("dbo.Yorums", new[] { "musteri_Id" });
            DropIndex("dbo.Yildizs", new[] { "Yorum_Id" });
            DropIndex("dbo.Yildizs", new[] { "Otel_Id" });
            DropIndex("dbo.Otels", new[] { "Iller_Id" });
            DropIndex("dbo.Odas", new[] { "otel_Id" });
            DropIndex("dbo.Mahalles", new[] { "Ilce_Id" });
            DropIndex("dbo.Ilces", new[] { "Il_Id" });
            DropTable("dbo.Rezervasyons");
            DropTable("dbo.OtelResimleris");
            DropTable("dbo.Ozelliks");
            DropTable("dbo.OtelOzelligis");
            DropTable("dbo.Yorums");
            DropTable("dbo.Yildizs");
            DropTable("dbo.Otels");
            DropTable("dbo.Odas");
            DropTable("dbo.Musteris");
            DropTable("dbo.Ils");
            DropTable("dbo.Mahalles");
            DropTable("dbo.Ilces");
        }
    }
}

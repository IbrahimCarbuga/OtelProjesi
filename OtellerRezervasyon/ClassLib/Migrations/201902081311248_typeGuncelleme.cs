namespace ClassLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class typeGuncelleme : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ilceler", "IlceAdi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Ilceler", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Ilceler", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Mahalleler", "MahalleAdi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Mahalleler", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Mahalleler", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Iller", "IlAdi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Iller", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Iller", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Musteriler", "Adi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Musteriler", "Soyadi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Musteriler", "Sifre", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Musteriler", "KullaniciAdi", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Musteriler", "Telefon", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Musteriler", "EMail", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Musteriler", "TcNo", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Musteriler", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Musteriler", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Odalar", "OdaNumarasi", c => c.String(nullable: false, maxLength: 5));
            AlterColumn("dbo.Odalar", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Odalar", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Oteller", "Adi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Oteller", "VergiNo", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Oteller", "ResmiAdi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Oteller", "Aciklama", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Oteller", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Oteller", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Yildizlar", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Yildizlar", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Yorumlar", "YorumBasligi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Yorumlar", "YorumIcerigi", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Yorumlar", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Yorumlar", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.OtelOzellikleri", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.OtelOzellikleri", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Ozellikler", "OzellikAdi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Ozellikler", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Ozellikler", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.OtelResimleri", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.OtelResimleri", "GuncelleyenKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Rezervasyonlar", "OlusturanKisi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Rezervasyonlar", "GuncelleyenKisi", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rezervasyonlar", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.Rezervasyonlar", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.OtelResimleri", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.OtelResimleri", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.Ozellikler", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.Ozellikler", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.Ozellikler", "OzellikAdi", c => c.String());
            AlterColumn("dbo.OtelOzellikleri", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.OtelOzellikleri", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.Yorumlar", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.Yorumlar", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.Yorumlar", "YorumIcerigi", c => c.String());
            AlterColumn("dbo.Yorumlar", "YorumBasligi", c => c.String());
            AlterColumn("dbo.Yildizlar", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.Yildizlar", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.Oteller", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.Oteller", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.Oteller", "Aciklama", c => c.String());
            AlterColumn("dbo.Oteller", "ResmiAdi", c => c.String());
            AlterColumn("dbo.Oteller", "VergiNo", c => c.String());
            AlterColumn("dbo.Oteller", "Adi", c => c.String());
            AlterColumn("dbo.Odalar", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.Odalar", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.Odalar", "OdaNumarasi", c => c.String());
            AlterColumn("dbo.Musteriler", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.Musteriler", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.Musteriler", "TcNo", c => c.String());
            AlterColumn("dbo.Musteriler", "EMail", c => c.String());
            AlterColumn("dbo.Musteriler", "Telefon", c => c.String());
            AlterColumn("dbo.Musteriler", "KullaniciAdi", c => c.String());
            AlterColumn("dbo.Musteriler", "Sifre", c => c.String());
            AlterColumn("dbo.Musteriler", "Soyadi", c => c.String());
            AlterColumn("dbo.Musteriler", "Adi", c => c.String());
            AlterColumn("dbo.Iller", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.Iller", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.Iller", "IlAdi", c => c.String());
            AlterColumn("dbo.Mahalleler", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.Mahalleler", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.Mahalleler", "MahalleAdi", c => c.String());
            AlterColumn("dbo.Ilceler", "GuncelleyenKisi", c => c.String());
            AlterColumn("dbo.Ilceler", "OlusturanKisi", c => c.String());
            AlterColumn("dbo.Ilceler", "IlceAdi", c => c.String());
        }
    }
}

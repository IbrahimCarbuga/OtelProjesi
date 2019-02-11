namespace ClassLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Ilces", newName: "Ilceler");
            RenameTable(name: "dbo.Mahalles", newName: "Mahalleler");
            RenameTable(name: "dbo.Ils", newName: "Iller");
            RenameTable(name: "dbo.Musteris", newName: "Musteriler");
            RenameTable(name: "dbo.Odas", newName: "Odalar");
            RenameTable(name: "dbo.Otels", newName: "Oteller");
            RenameTable(name: "dbo.Yildizs", newName: "Yildizlar");
            RenameTable(name: "dbo.Yorums", newName: "Yorumlar");
            RenameTable(name: "dbo.OtelOzelligis", newName: "OtelOzellikleri");
            RenameTable(name: "dbo.Ozelliks", newName: "Ozellikler");
            RenameTable(name: "dbo.OtelResimleris", newName: "OtelResimleri");
            RenameTable(name: "dbo.Rezervasyons", newName: "Rezervasyonlar");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Rezervasyonlar", newName: "Rezervasyons");
            RenameTable(name: "dbo.OtelResimleri", newName: "OtelResimleris");
            RenameTable(name: "dbo.Ozellikler", newName: "Ozelliks");
            RenameTable(name: "dbo.OtelOzellikleri", newName: "OtelOzelligis");
            RenameTable(name: "dbo.Yorumlar", newName: "Yorums");
            RenameTable(name: "dbo.Yildizlar", newName: "Yildizs");
            RenameTable(name: "dbo.Oteller", newName: "Otels");
            RenameTable(name: "dbo.Odalar", newName: "Odas");
            RenameTable(name: "dbo.Musteriler", newName: "Musteris");
            RenameTable(name: "dbo.Iller", newName: "Ils");
            RenameTable(name: "dbo.Mahalleler", newName: "Mahalles");
            RenameTable(name: "dbo.Ilceler", newName: "Ilces");
        }
    }
}

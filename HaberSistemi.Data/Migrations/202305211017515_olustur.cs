namespace HaberSistemi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class olustur : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategori",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(maxLength: 150),
                        ParentID = c.Int(nullable: false),
                        URL = c.String(maxLength: 150),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Haber", "Kategori_Id", c => c.Int());
            CreateIndex("dbo.Haber", "Kategori_Id");
            AddForeignKey("dbo.Haber", "Kategori_Id", "dbo.Kategori", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Haber", "Kategori_Id", "dbo.Kategori");
            DropIndex("dbo.Haber", new[] { "Kategori_Id" });
            DropColumn("dbo.Haber", "Kategori_Id");
            DropTable("dbo.Kategori");
        }
    }
}

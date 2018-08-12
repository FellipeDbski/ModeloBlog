namespace TrianguloArquitetura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Publicacaos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        SubTitulo = c.String(),
                        Imagem = c.Binary(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SubImagens",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PublicacaoID = c.Int(nullable: false),
                        Descriacao = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Publicacaos", t => t.PublicacaoID, cascadeDelete: true)
                .Index(t => t.PublicacaoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubImagens", "PublicacaoID", "dbo.Publicacaos");
            DropIndex("dbo.SubImagens", new[] { "PublicacaoID" });
            DropTable("dbo.SubImagens");
            DropTable("dbo.Publicacaos");
        }
    }
}

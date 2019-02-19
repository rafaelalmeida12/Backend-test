namespace BackEndTesteGrupoRovema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoRelacionamentoentreclassesProdutoeCategoria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProdutoCategoria",
                c => new
                    {
                        Produto_Id = c.Int(nullable: false),
                        Categoria_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Produto_Id, t.Categoria_Id })
                .ForeignKey("dbo.Produto", t => t.Produto_Id, cascadeDelete: true)
                .ForeignKey("dbo.Categoria", t => t.Categoria_Id, cascadeDelete: true)
                .Index(t => t.Produto_Id)
                .Index(t => t.Categoria_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProdutoCategoria", "Categoria_Id", "dbo.Categoria");
            DropForeignKey("dbo.ProdutoCategoria", "Produto_Id", "dbo.Produto");
            DropIndex("dbo.ProdutoCategoria", new[] { "Categoria_Id" });
            DropIndex("dbo.ProdutoCategoria", new[] { "Produto_Id" });
            DropTable("dbo.ProdutoCategoria");
        }
    }
}

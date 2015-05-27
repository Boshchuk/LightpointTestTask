namespace LightpointTestTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Description = c.String(),
                        Store_StoreId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Stores", t => t.Store_StoreId)
                .Index(t => t.Store_StoreId);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        StoreId = c.Int(nullable: false, identity: true),
                        StoreName = c.String(),
                        Address = c.String(),
                        WorkHours = c.String(),
                    })
                .PrimaryKey(t => t.StoreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Store_StoreId", "dbo.Stores");
            DropIndex("dbo.Products", new[] { "Store_StoreId" });
            DropTable("dbo.Stores");
            DropTable("dbo.Products");
        }
    }
}

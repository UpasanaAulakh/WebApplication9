namespace WebApplication9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.categaries",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        myproperty = c.String(),
                        quality = c.Int(nullable: false),
                        price = c.Int(nullable: false),
                        Description = c.String(),
                        categary_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.categaries", t => t.categary_id)
                .Index(t => t.categary_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.products", "categary_id", "dbo.categaries");
            DropIndex("dbo.products", new[] { "categary_id" });
            DropTable("dbo.products");
            DropTable("dbo.categaries");
        }
    }
}

namespace WebApplication9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.products", "name", c => c.String());
            DropColumn("dbo.products", "myproperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.products", "myproperty", c => c.String());
            DropColumn("dbo.products", "name");
        }
    }
}

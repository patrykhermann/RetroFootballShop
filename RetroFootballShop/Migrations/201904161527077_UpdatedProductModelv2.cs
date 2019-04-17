namespace RetroFootballShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedProductModelv2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Description", c => c.String());
            DropColumn("dbo.Products", "Describtion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Describtion", c => c.String());
            DropColumn("dbo.Products", "Description");
        }
    }
}

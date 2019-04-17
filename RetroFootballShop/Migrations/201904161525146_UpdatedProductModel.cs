namespace RetroFootballShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedProductModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ImgFileName", c => c.String());
            DropColumn("dbo.Products", "CoverFileName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "CoverFileName", c => c.String());
            DropColumn("dbo.Products", "ImgFileName");
        }
    }
}

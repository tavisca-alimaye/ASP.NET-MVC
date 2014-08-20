namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedPriceToFare : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Fare", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Movies", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Movies", "Fare");
        }
    }
}

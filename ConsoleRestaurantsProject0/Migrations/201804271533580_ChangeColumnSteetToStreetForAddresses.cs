namespace ConsoleRestaurantsProject0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeColumnSteetToStreetForAddresses : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "Street", c => c.String());
            Sql("UPDATE dbo.Addresses SET Street = Steet");
            DropColumn("dbo.Addresses", "Steet");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Addresses", "Steet", c => c.String());
            Sql("UPDATE dbo.Addresses SET Steet = Street");
            DropColumn("dbo.Addresses", "Street");
        }
    }
}

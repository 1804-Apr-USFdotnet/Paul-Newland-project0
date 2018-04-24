namespace ConsoleRestaurantsProject0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRatingToReviews : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Rating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "Rating");
        }
    }
}

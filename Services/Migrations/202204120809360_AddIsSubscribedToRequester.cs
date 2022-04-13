namespace Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribedToRequester : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Requesters", "IsSubscribedToNewLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Requesters", "IsSubscribedToNewLetter");
        }
    }
}

namespace Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBirthDateToRequester : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Requesters", "BirthDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Requesters", "BirthDate");
        }
    }
}

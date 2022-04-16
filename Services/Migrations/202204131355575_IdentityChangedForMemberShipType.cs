namespace Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdentityChangedForMemberShipType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Requesters", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Requesters", "Name", c => c.String());
        }
    }
}

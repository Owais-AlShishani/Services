namespace Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemeberShipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberShipTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Requesters", "MemberShipTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Requesters", "MemberShipType_Id", c => c.Int());
            CreateIndex("dbo.Requesters", "MemberShipType_Id");
            AddForeignKey("dbo.Requesters", "MemberShipType_Id", "dbo.MemberShipTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requesters", "MemberShipType_Id", "dbo.MemberShipTypes");
            DropIndex("dbo.Requesters", new[] { "MemberShipType_Id" });
            DropColumn("dbo.Requesters", "MemberShipType_Id");
            DropColumn("dbo.Requesters", "MemberShipTypeId");
            DropTable("dbo.MemberShipTypes");
        }
    }
}

namespace Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNameValuesToMemberShipTypeModel : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE  MemberShipTypes set Name='Pay as You Go' where id=1");
            Sql("UPDATE  MemberShipTypes set Name='Monthly' where id=2");
            Sql("UPDATE  MemberShipTypes set Name='Monthly' where id=3");
            Sql("UPDATE  MemberShipTypes set Name='Annual' where id=4");
        }
        
        public override void Down()
        {
        }
    }
}

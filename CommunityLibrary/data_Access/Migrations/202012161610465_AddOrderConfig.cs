namespace data_Access.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderConfig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "ReciveTime", c => c.DateTime());
            AlterColumn("dbo.Orders", "ReturnTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "ReturnTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Orders", "ReciveTime", c => c.DateTime(nullable: false));
        }
    }
}

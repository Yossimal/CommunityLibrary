namespace data_Access.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOfferConfig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Offers", "CreateDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Offers", "CreateDate", c => c.DateTime());
        }
    }
}

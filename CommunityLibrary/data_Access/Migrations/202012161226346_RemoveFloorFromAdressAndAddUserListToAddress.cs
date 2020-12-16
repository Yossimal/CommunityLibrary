namespace data_Access.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveFloorFromAdressAndAddUserListToAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Offers", "BookId", c => c.Int(nullable: false));
            DropColumn("dbo.Addresses", "Floor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Addresses", "Floor", c => c.String());
            DropColumn("dbo.Offers", "BookId");
        }
    }
}

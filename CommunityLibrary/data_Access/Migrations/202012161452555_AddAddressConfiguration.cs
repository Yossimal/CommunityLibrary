namespace data_Access.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAddressConfiguration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "ZipCode", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "Country", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Addresses", "Country", c => c.String());
            AlterColumn("dbo.Addresses", "ZipCode", c => c.String());
        }
    }
}

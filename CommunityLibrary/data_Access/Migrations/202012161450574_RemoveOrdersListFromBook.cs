namespace data_Access.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveOrdersListFromBook : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Book_Id", "dbo.Books");
            DropIndex("dbo.Orders", new[] { "Book_Id" });
            DropColumn("dbo.Orders", "Book_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Book_Id", c => c.Long());
            CreateIndex("dbo.Orders", "Book_Id");
            AddForeignKey("dbo.Orders", "Book_Id", "dbo.Books", "Id");
        }
    }
}

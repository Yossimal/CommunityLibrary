namespace data_Access.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveBookListFromUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "User_Id", "dbo.Users");
            DropIndex("dbo.Books", new[] { "User_Id" });
            DropColumn("dbo.Books", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "User_Id", c => c.Long());
            CreateIndex("dbo.Books", "User_Id");
            AddForeignKey("dbo.Books", "User_Id", "dbo.Users", "Id");
        }
    }
}

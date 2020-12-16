namespace data_Access.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Floor = c.String(),
                        Apartment = c.String(),
                        Enterance = c.String(),
                        HouseNumber = c.String(),
                        StreatAddress = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Author = c.String(),
                        BarCode = c.String(),
                        User_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Offers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StatusDescription = c.String(),
                        CreateDate = c.DateTime(),
                        DaysForGive = c.Int(nullable: false),
                        DaysForReturn = c.Int(nullable: false),
                        Book_Id = c.Long(),
                        OfferUser_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .ForeignKey("dbo.Users", t => t.OfferUser_Id)
                .Index(t => t.Book_Id)
                .Index(t => t.OfferUser_Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UserId = c.Long(nullable: false),
                        CommentId = c.Long(nullable: false),
                        Rating = c.Int(nullable: false),
                        Reference = c.Int(nullable: false),
                        Content = c.String(),
                        Offer_Id = c.Int(),
                        Order_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Offers", t => t.Offer_Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.UserId)
                .Index(t => t.Offer_Id)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        EmailAddress = c.String(),
                        PhoneNumber = c.String(),
                        LendingCount = c.Long(nullable: false),
                        Role = c.Int(nullable: false),
                        AddressId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        ReciveTime = c.DateTime(nullable: false),
                        ReturnTime = c.DateTime(nullable: false),
                        OrderId_Id = c.Int(),
                        UserId_Id = c.Long(),
                        Book_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Offers", t => t.OrderId_Id)
                .ForeignKey("dbo.Users", t => t.UserId_Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .Index(t => t.OrderId_Id)
                .Index(t => t.UserId_Id)
                .Index(t => t.Book_Id);
            
            CreateTable(
                "dbo.OrderOrders",
                c => new
                    {
                        Order_Id = c.Long(nullable: false),
                        Order_Id1 = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.Order_Id, t.Order_Id1 })
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id1)
                .Index(t => t.Order_Id)
                .Index(t => t.Order_Id1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.Orders", "UserId_Id", "dbo.Users");
            DropForeignKey("dbo.Orders", "OrderId_Id", "dbo.Offers");
            DropForeignKey("dbo.Comments", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.OrderOrders", "Order_Id1", "dbo.Orders");
            DropForeignKey("dbo.OrderOrders", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Offers", "OfferUser_Id", "dbo.Users");
            DropForeignKey("dbo.Comments", "UserId", "dbo.Users");
            DropForeignKey("dbo.Books", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.Comments", "Offer_Id", "dbo.Offers");
            DropForeignKey("dbo.Offers", "Book_Id", "dbo.Books");
            DropIndex("dbo.OrderOrders", new[] { "Order_Id1" });
            DropIndex("dbo.OrderOrders", new[] { "Order_Id" });
            DropIndex("dbo.Orders", new[] { "Book_Id" });
            DropIndex("dbo.Orders", new[] { "UserId_Id" });
            DropIndex("dbo.Orders", new[] { "OrderId_Id" });
            DropIndex("dbo.Users", new[] { "AddressId" });
            DropIndex("dbo.Comments", new[] { "Order_Id" });
            DropIndex("dbo.Comments", new[] { "Offer_Id" });
            DropIndex("dbo.Comments", new[] { "UserId" });
            DropIndex("dbo.Offers", new[] { "OfferUser_Id" });
            DropIndex("dbo.Offers", new[] { "Book_Id" });
            DropIndex("dbo.Books", new[] { "User_Id" });
            DropTable("dbo.OrderOrders");
            DropTable("dbo.Orders");
            DropTable("dbo.Users");
            DropTable("dbo.Comments");
            DropTable("dbo.Offers");
            DropTable("dbo.Books");
            DropTable("dbo.Addresses");
        }
    }
}

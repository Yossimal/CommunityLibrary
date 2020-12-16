namespace data_Access.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyOrdersAndMore : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderOrders", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.OrderOrders", "Order_Id1", "dbo.Orders");
            DropForeignKey("dbo.Comments", "Order_Id", "dbo.Orders");
            DropIndex("dbo.Comments", new[] { "Order_Id" });
            DropIndex("dbo.OrderOrders", new[] { "Order_Id" });
            DropIndex("dbo.OrderOrders", new[] { "Order_Id1" });
            RenameColumn(table: "dbo.Comments", name: "Order_Id", newName: "OrderId");
            RenameColumn(table: "dbo.Orders", name: "OrderId_Id", newName: "Offer_Id");
            RenameIndex(table: "dbo.Orders", name: "IX_OrderId_Id", newName: "IX_Offer_Id");
            AddColumn("dbo.Comments", "OfferId", c => c.Long(nullable: false));
            AddColumn("dbo.Orders", "OfferId", c => c.Long(nullable: false));
            AlterColumn("dbo.Comments", "OrderId", c => c.Long(nullable: false));
            CreateIndex("dbo.Comments", "OrderId");
            AddForeignKey("dbo.Comments", "OrderId", "dbo.Orders", "Id", cascadeDelete: true);
            DropColumn("dbo.Comments", "CommentId");
            DropTable("dbo.OrderOrders");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.OrderOrders",
                c => new
                    {
                        Order_Id = c.Long(nullable: false),
                        Order_Id1 = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.Order_Id, t.Order_Id1 });
            
            AddColumn("dbo.Comments", "CommentId", c => c.Long(nullable: false));
            DropForeignKey("dbo.Comments", "OrderId", "dbo.Orders");
            DropIndex("dbo.Comments", new[] { "OrderId" });
            AlterColumn("dbo.Comments", "OrderId", c => c.Long());
            DropColumn("dbo.Orders", "OfferId");
            DropColumn("dbo.Comments", "OfferId");
            RenameIndex(table: "dbo.Orders", name: "IX_Offer_Id", newName: "IX_OrderId_Id");
            RenameColumn(table: "dbo.Orders", name: "Offer_Id", newName: "OrderId_Id");
            RenameColumn(table: "dbo.Comments", name: "OrderId", newName: "Order_Id");
            CreateIndex("dbo.OrderOrders", "Order_Id1");
            CreateIndex("dbo.OrderOrders", "Order_Id");
            CreateIndex("dbo.Comments", "Order_Id");
            AddForeignKey("dbo.Comments", "Order_Id", "dbo.Orders", "Id");
            AddForeignKey("dbo.OrderOrders", "Order_Id1", "dbo.Orders", "Id");
            AddForeignKey("dbo.OrderOrders", "Order_Id", "dbo.Orders", "Id");
        }
    }
}

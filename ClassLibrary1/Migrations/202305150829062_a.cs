namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClientId);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        RoomsCount = c.Int(nullable: false),
                        DaysCount = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Client_ClientId = c.Int(),
                        Restaurant_RestaurantId = c.Int(),
                    })
                .PrimaryKey(t => t.ReservationId)
                .ForeignKey("dbo.Clients", t => t.Client_ClientId)
                .ForeignKey("dbo.Restaurants", t => t.Restaurant_RestaurantId)
                .Index(t => t.Client_ClientId)
                .Index(t => t.Restaurant_RestaurantId);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        RestaurantId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(nullable: false),
                        Income = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.RestaurantId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "Restaurant_RestaurantId", "dbo.Restaurants");
            DropForeignKey("dbo.Reservations", "Client_ClientId", "dbo.Clients");
            DropIndex("dbo.Reservations", new[] { "Restaurant_RestaurantId" });
            DropIndex("dbo.Reservations", new[] { "Client_ClientId" });
            DropTable("dbo.Restaurants");
            DropTable("dbo.Reservations");
            DropTable("dbo.Clients");
        }
    }
}

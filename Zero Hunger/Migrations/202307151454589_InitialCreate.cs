namespace Zero_Hunger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(),
                        EmployeeContoncet = c.Int(nullable: false),
                        EmployeeEmail = c.String(),
                        EmployeeGender = c.String(),
                        EmployeeAddrererss = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            CreateTable(
                "dbo.EmployeeAssingns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeID = c.Int(nullable: false),
                        RestaurantID = c.Int(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .ForeignKey("dbo.Restaurants", t => t.RestaurantID, cascadeDelete: true)
                .Index(t => t.EmployeeID)
                .Index(t => t.RestaurantID);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        RestaurantID = c.Int(nullable: false, identity: true),
                        RestaurantName = c.String(),
                        RestaurantDescription = c.String(),
                        RestaurantContonct = c.String(),
                        RestaurantEmail = c.String(),
                        RestaurantOwner = c.String(),
                        RestaurantAddress = c.String(),
                    })
                .PrimaryKey(t => t.RestaurantID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeAssingns", "RestaurantID", "dbo.Restaurants");
            DropForeignKey("dbo.EmployeeAssingns", "EmployeeID", "dbo.Employees");
            DropIndex("dbo.EmployeeAssingns", new[] { "RestaurantID" });
            DropIndex("dbo.EmployeeAssingns", new[] { "EmployeeID" });
            DropTable("dbo.Restaurants");
            DropTable("dbo.EmployeeAssingns");
            DropTable("dbo.Employees");
        }
    }
}

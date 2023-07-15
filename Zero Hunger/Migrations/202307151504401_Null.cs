namespace Zero_Hunger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Null : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "EmployeeName", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "EmployeeEmail", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "EmployeeGender", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "EmployeeAddrererss", c => c.String(nullable: false));
            AlterColumn("dbo.EmployeeAssingns", "Status", c => c.String(nullable: false));
            AlterColumn("dbo.Restaurants", "RestaurantName", c => c.String(nullable: false));
            AlterColumn("dbo.Restaurants", "RestaurantDescription", c => c.String(nullable: false));
            AlterColumn("dbo.Restaurants", "RestaurantContonct", c => c.String(nullable: false));
            AlterColumn("dbo.Restaurants", "RestaurantEmail", c => c.String(nullable: false));
            AlterColumn("dbo.Restaurants", "RestaurantOwner", c => c.String(nullable: false));
            AlterColumn("dbo.Restaurants", "RestaurantAddress", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Restaurants", "RestaurantAddress", c => c.String());
            AlterColumn("dbo.Restaurants", "RestaurantOwner", c => c.String());
            AlterColumn("dbo.Restaurants", "RestaurantEmail", c => c.String());
            AlterColumn("dbo.Restaurants", "RestaurantContonct", c => c.String());
            AlterColumn("dbo.Restaurants", "RestaurantDescription", c => c.String());
            AlterColumn("dbo.Restaurants", "RestaurantName", c => c.String());
            AlterColumn("dbo.EmployeeAssingns", "Status", c => c.String());
            AlterColumn("dbo.Employees", "EmployeeAddrererss", c => c.String());
            AlterColumn("dbo.Employees", "EmployeeGender", c => c.String());
            AlterColumn("dbo.Employees", "EmployeeEmail", c => c.String());
            AlterColumn("dbo.Employees", "EmployeeName", c => c.String());
        }
    }
}

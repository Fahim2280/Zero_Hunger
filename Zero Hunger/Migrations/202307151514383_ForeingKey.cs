namespace Zero_Hunger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeingKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "EmployeeCont", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "EmployeeAddress", c => c.String(nullable: false));
            AddColumn("dbo.Restaurants", "RestaurantCont", c => c.String(nullable: false));
            DropColumn("dbo.Employees", "EmployeeContoncet");
            DropColumn("dbo.Employees", "EmployeeAddrererss");
            DropColumn("dbo.Restaurants", "RestaurantContonct");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Restaurants", "RestaurantContonct", c => c.String(nullable: false));
            AddColumn("dbo.Employees", "EmployeeAddrererss", c => c.String(nullable: false));
            AddColumn("dbo.Employees", "EmployeeContoncet", c => c.Int(nullable: false));
            DropColumn("dbo.Restaurants", "RestaurantCont");
            DropColumn("dbo.Employees", "EmployeeAddress");
            DropColumn("dbo.Employees", "EmployeeCont");
        }
    }
}

namespace Cars.Web.Database.DomainMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SettingNewSchema : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.Cars", newSchema: "domain");
        }
        
        public override void Down()
        {
            MoveTable(name: "domain.Cars", newSchema: "dbo");
        }
    }
}

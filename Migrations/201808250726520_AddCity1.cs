namespace ConsoleApp4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCity1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.People", name: "ProfessionName", newName: "Profession");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.People", name: "Profession", newName: "ProfessionName");
        }
    }
}

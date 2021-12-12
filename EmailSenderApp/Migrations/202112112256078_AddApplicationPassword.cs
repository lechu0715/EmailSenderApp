namespace EmailSenderApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddApplicationPassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ApplicationPassword", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ApplicationPassword");
        }
    }
}

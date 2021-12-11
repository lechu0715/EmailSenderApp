namespace EmailSenderApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmailModels", "UserId", "dbo.AspNetUsers");
            AddForeignKey("dbo.EmailModels", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmailModels", "UserId", "dbo.AspNetUsers");
            AddForeignKey("dbo.EmailModels", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}

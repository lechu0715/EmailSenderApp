namespace EmailSenderApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmailModels", "Text", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmailModels", "Text", c => c.String(nullable: false));
        }
    }
}

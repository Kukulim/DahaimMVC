namespace DahaimMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class confirmpass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "ConfirmPassword", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "ConfirmPassword");
        }
    }
}

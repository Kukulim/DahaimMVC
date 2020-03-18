namespace DahaimMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialmessage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MessageName = c.String(nullable: false),
                        MessageEmail = c.String(nullable: false),
                        MessageText = c.String(nullable: false),
                        Readed = c.Byte(nullable: false),
                        SendTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
        }
    }
}

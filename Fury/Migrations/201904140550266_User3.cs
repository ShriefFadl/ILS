namespace Fury.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Auth");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Auth", c => c.Int(nullable: false));
        }
    }
}

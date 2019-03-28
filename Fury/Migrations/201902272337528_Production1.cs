namespace Fury.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Production1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Productions", "Date_submit");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Productions", "Date_submit", c => c.DateTime(nullable: false));
        }
    }
}

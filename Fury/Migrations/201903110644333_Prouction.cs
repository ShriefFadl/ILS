namespace Fury.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Prouction : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.workshops",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Productions", "workshop_ID", c => c.Int());
            CreateIndex("dbo.Productions", "workshop_ID");
            AddForeignKey("dbo.Productions", "workshop_ID", "dbo.workshops", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productions", "workshop_ID", "dbo.workshops");
            DropIndex("dbo.Productions", new[] { "workshop_ID" });
            DropColumn("dbo.Productions", "workshop_ID");
            DropTable("dbo.workshops");
        }
    }
}

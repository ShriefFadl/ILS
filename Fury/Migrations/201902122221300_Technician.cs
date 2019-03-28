namespace Fury.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Technician : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Technicians",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        Auth = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Technicians");
        }
    }
}

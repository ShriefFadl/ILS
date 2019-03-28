namespace Fury.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Production : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Productions");
            AddColumn("dbo.Productions", "FSCM", c => c.String(nullable: false, maxLength: 5));
            AddColumn("dbo.Productions", "Part_num", c => c.String(nullable: false, maxLength: 32));
            AddColumn("dbo.Productions", "Serial_Num", c => c.String(nullable: false, maxLength: 15));
            AddColumn("dbo.Productions", "NiiN", c => c.String(nullable: false, maxLength: 9));
            AddPrimaryKey("dbo.Productions", "FSCM");
            DropColumn("dbo.Productions", "ID");
            DropColumn("dbo.Productions", "Stock_num");
            DropColumn("dbo.Productions", "Discription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Productions", "Discription", c => c.String());
            AddColumn("dbo.Productions", "Stock_num", c => c.String());
            AddColumn("dbo.Productions", "ID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Productions");
            DropColumn("dbo.Productions", "NiiN");
            DropColumn("dbo.Productions", "Serial_Num");
            DropColumn("dbo.Productions", "Part_num");
            DropColumn("dbo.Productions", "FSCM");
            AddPrimaryKey("dbo.Productions", "ID");
        }
    }
}

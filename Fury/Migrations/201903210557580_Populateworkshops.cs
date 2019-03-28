namespace Fury.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Populateworkshops : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO workshops(ID,name) VALUES(1,'MISSILES')");
            Sql("INSERT INTO workshops(ID,name) VALUES(2,'ENGINE')");
            Sql("INSERT INTO workshops(ID,name) VALUES(3,'CABINE')");
            Sql("INSERT INTO workshops(ID,name) VALUES(4,'FUEL TANK')");
        }
        
        public override void Down()
        {
        }
    }
}

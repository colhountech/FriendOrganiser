namespace FO.DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSeed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Friend",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(nullable: false, maxLength: 50),
                        Lastname = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Friend");
        }
    }
}

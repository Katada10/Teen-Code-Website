namespace TeenCodeWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Removed1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SMLinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PageUrl = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SMLinks");
        }
    }
}

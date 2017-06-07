namespace TeenCodeWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SmLinks : DbMigration
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
            
            DropTable("dbo.Certifications");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Certifications",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IMGURL = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.SMLinks");
        }
    }
}

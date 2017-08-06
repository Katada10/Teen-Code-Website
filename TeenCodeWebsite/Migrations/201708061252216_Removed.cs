namespace TeenCodeWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Removed : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.SMLinks");
        }
        
        public override void Down()
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
    }
}

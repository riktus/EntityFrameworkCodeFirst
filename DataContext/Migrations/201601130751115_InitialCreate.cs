namespace DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlayStation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsBundle = c.Boolean(nullable: false),
                        Revision = c.String(),
                        Color = c.String(),
                        MemoryCapacity = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlayStation_PS4",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ModelType = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayStation", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.PlayStation_PSVita",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayStation", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayStation_PSVita", "Id", "dbo.PlayStation");
            DropForeignKey("dbo.PlayStation_PS4", "Id", "dbo.PlayStation");
            DropIndex("dbo.PlayStation_PSVita", new[] { "Id" });
            DropIndex("dbo.PlayStation_PS4", new[] { "Id" });
            DropTable("dbo.PlayStation_PSVita");
            DropTable("dbo.PlayStation_PS4");
            DropTable("dbo.PlayStation");
        }
    }
}

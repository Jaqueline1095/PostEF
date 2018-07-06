namespace PostEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        IdC = c.Int(nullable: false, identity: true),
                        NameCa = c.String(),
                    })
                .PrimaryKey(t => t.IdC);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        IdCo = c.Int(nullable: false, identity: true),
                        NameComent = c.String(),
                        TextComent = c.String(),
                        DateComent = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdCo);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        IdP = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdP);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Posts");
            DropTable("dbo.Comments");
            DropTable("dbo.Categories");
        }
    }
}

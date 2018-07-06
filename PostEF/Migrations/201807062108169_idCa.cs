namespace PostEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class idCa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "IdC", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "IdC");
        }
    }
}

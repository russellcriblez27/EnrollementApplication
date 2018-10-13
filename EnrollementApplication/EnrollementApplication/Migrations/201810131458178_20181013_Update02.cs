namespace EnrollementApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20181013_Update02 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Age");
        }
    }
}

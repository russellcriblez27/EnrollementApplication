namespace EnrollementApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20181013_Update03 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enrollments", "Notes", c => c.String());
            AlterColumn("dbo.Courses", "Credits", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "Credits", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Enrollments", "Notes");
        }
    }
}

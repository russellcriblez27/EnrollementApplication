namespace EnrollementApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20181013_Update01 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "InstructorName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "InstructorName");
        }
    }
}

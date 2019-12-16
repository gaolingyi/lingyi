namespace CourseManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _201912101115 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CourseManagements", "ClassName");
            DropColumn("dbo.CourseManagements", "CourseName");
            DropColumn("dbo.CourseManagements", "TeacherName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CourseManagements", "TeacherName", c => c.String());
            AddColumn("dbo.CourseManagements", "CourseName", c => c.String());
            AddColumn("dbo.CourseManagements", "ClassName", c => c.String());
        }
    }
}

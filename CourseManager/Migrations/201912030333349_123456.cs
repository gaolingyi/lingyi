namespace CourseManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _123456 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CourseManagements", "ClassName", c => c.Int(nullable: false));
            AddColumn("dbo.CourseManagements", "CourseName", c => c.String());
            AddColumn("dbo.CourseManagements", "TeacherName", c => c.String());
            DropColumn("dbo.CourseManagements", "ClassId");
            DropColumn("dbo.CourseManagements", "CourseId");
            DropColumn("dbo.CourseManagements", "TeacherId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CourseManagements", "TeacherId", c => c.Int(nullable: false));
            AddColumn("dbo.CourseManagements", "CourseId", c => c.Int(nullable: false));
            AddColumn("dbo.CourseManagements", "ClassId", c => c.Int(nullable: false));
            DropColumn("dbo.CourseManagements", "TeacherName");
            DropColumn("dbo.CourseManagements", "CourseName");
            DropColumn("dbo.CourseManagements", "ClassName");
        }
    }
}

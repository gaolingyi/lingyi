namespace CourseManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uuuuuu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "Nmae", c => c.String());
            AlterColumn("dbo.CourseManagements", "ClassName", c => c.String());
            AlterColumn("dbo.CourseManagements", "ClassId", c => c.Int(nullable: false));
            AlterColumn("dbo.CourseManagements", "CourseId", c => c.Int(nullable: false));
            AlterColumn("dbo.CourseManagements", "TeacherId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CourseManagements", "TeacherId", c => c.String());
            AlterColumn("dbo.CourseManagements", "CourseId", c => c.String());
            AlterColumn("dbo.CourseManagements", "ClassId", c => c.String());
            AlterColumn("dbo.CourseManagements", "ClassName", c => c.Int(nullable: false));
            DropColumn("dbo.Teachers", "Nmae");
        }
    }
}

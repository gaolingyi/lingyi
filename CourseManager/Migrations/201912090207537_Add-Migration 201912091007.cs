namespace CourseManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMigration201912091007 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CourseManagements", "ClassId", c => c.String());
            AddColumn("dbo.CourseManagements", "CourseId", c => c.String());
            AddColumn("dbo.CourseManagements", "TeacherId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CourseManagements", "TeacherId");
            DropColumn("dbo.CourseManagements", "CourseId");
            DropColumn("dbo.CourseManagements", "ClassId");
        }
    }
}

using CourseManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.Migrations.Seeds
{
    public class SideBarCreator
    {
        private readonly CourseManager.Models.CourseManagerContext _context;

        public SideBarCreator(CourseManager.Models.CourseManagerContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            var initialSideBars = new List<SideBars>
            {
                new SideBars
                {
                    Name = "班级管理",
                    Controller = "Home",
                    Action = "Index",
                },
                    new SideBars
                {
                    Name = "教师管理",
                    Controller = "Techer",
                    Action = "Index",
                },
                    new SideBars
                {
                    Name = "学生管理",
                    Controller = "Student",
                    Action = "Index",
                },
                    new SideBars
                {
                    Name = "课程科目管理",
                    Controller = "Course",
                    Action = "Index",
                },
                    new SideBars
                {
                    Name = "课程安排",
                    Controller = "CourseManagements",
                    Action = "Index",
                },
                    new SideBars
                {
                    Name = "顶部导航栏管理",
                    Controller = "ActionLink",
                    Action = "Index",
                },
                    new SideBars
                {
                    Name = "侧边栏管理",
                    Controller = "SideBar",
                    Action = "Index",
                }
            };
            foreach (var bar in initialSideBars)
            {
                if (_context.SideBars.Any(r => r.Name == bar.Name))
                {
                    continue;
                }
                _context.SideBars.Add(bar);
            }
            _context.SaveChanges();
        }
    }
}
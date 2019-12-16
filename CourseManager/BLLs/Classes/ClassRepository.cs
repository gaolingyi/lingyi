using CourseManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.BLLs.Classes
{
    public class ClassRepository : IClassRepository
    {
        protected CourseManagerContext db = new CourseManagerContext();
        public List<CourseDetail> GetClassCouse(int id)
        {
            var query =
                from cm in db.CourseManagements
                join c in db.Classes
                     on cm.ClassId equals c.ID
                join cr in db.Course
                     on cm.CourseId equals cr.Id
                join t in db.Teachers
                     on cm.ClassId equals t.ID
                select new CourseDetail
                {
                    ClassName = c.Name,
                    CourseName = cr.Name,
                    TeacherName = t.Name,
                };
            return query.ToList();
        }
    }
}
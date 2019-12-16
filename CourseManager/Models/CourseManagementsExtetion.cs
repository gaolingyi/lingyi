using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.Models
{
    public partial class CourseManagements
    {
        public string ClassName
        {
            get
            {
                if (ClassId==0)
                {
                    return "";
                }

                CourseManagerContext db = new CourseManagerContext();
                var classes = db.Classes.Where(t => t.ID == ClassId).FirstOrDefault();
                if (classes == null)
                {
                    return "";
                }
                return classes.Name;
            }
        }
        public string CourseName
        {
            get
            {
                if (CourseId == 0)
                {
                    return "";
                }

                CourseManagerContext db = new CourseManagerContext();
                var course = db.Course.Where(t => t.Id ==CourseId).FirstOrDefault();
                if (course == null)
                {
                    return "";
                }
                return course.Name;
            }
        }
        public string TeacherName
        {
            get
            {
                if (TeacherId == 0)
                {
                    return "";
                }

                CourseManagerContext db = new CourseManagerContext();
                var teacher = db.Teachers.Where(t => t.ID == TeacherId).FirstOrDefault();
                if (teacher == null)
                {
                    return "";
                }
                return teacher.Name;
            }
        }
    }
}
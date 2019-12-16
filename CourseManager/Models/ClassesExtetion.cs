using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.Models
{
    public partial class Classes
    {

        public string TeacherName
        {
            get
            {
                if (!TeacherID.HasValue)
                {
                    return "";
                }

                CourseManagerContext db = new CourseManagerContext();
                var teacher = db.Teachers.Where(t => t.ID == TeacherID.Value).FirstOrDefault();
                if (teacher == null)
                {
                    return "";
                }
                return teacher.Name;
            }
        }
    }
}
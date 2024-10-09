using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
       // public ICollection<TeacherCourse> TeacherCourses { get; set; }
    }
}

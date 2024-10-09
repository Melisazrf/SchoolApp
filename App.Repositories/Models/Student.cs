using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; } = default!;
        public int SchoolClassId { get; set; }
        //foreign key tanımlaması
        public virtual SchoolClass SchoolClass { get; set; }
        //her öğrencinin bir classı olur

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
        //bir öğrencinin birden fazla dersi olur
    }
}

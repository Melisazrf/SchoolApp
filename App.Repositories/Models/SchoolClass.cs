using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.Models
{
    public class SchoolClass
    {
        public int ClassId { get; set; }
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
		//bir sınıfın birden fazla öğrencisi olur

		//public ICollection<TeacherClass> TeacherClasses { get; set; }
        //her sınıfın ders verildiği öğretmenler olur
    }
}

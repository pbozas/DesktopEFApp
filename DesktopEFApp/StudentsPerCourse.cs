using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopEFApp
{
    public class StudentsPerCourse
    {
        public Course Course { get; set; }
        public ICollection<Student> Students { get; set; }

        public StudentsPerCourse(Course course, ICollection<Student> students)
        {
            Course = course;
            Students = students;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("The course name is: ");
            sb.Append(Course.Name);
            sb.Append(" and has the following students: \n");
            foreach (Student student in Students)
            {
                sb.Append(student.Name);
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}

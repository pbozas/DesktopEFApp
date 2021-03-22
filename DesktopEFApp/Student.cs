using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopEFApp
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("The student's id is: ");
            sb.Append(ID);
            sb.Append(" and his/her name is: ");
            sb.Append(Name);
            return sb.ToString();
        }
    }
}

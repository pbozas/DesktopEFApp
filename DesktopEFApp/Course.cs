using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopEFApp
{
    public class Course
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("The courses's id is: ");
            sb.Append(ID);
            sb.Append(" and it's name is: ");
            sb.Append(Name);
            return sb.ToString();
        }
    }
}

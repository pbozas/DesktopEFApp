using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopEFApp.DAL
{
    public class MeContext : DbContext
    {
        public MeContext() : base(@"Data Source=DESKTOP-UHUV6UP\SQLEXPRESS;Initial Catalog=MyTestDBManyToMany;Integrated Security=True") { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}

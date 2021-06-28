using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace SchoolProject.Data.Entities
{
    public class Standard
    {
        public Standard()
        {
            Students = new HashSet<Student>();

            Teachers = new HashSet<Teacher>();
        }

        public int StandardId { get; set; }

        public string Section { get; set; }

        public int TeacherId { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }

    }
    public class StandardConfig:EntityTypeConfiguration<Standard>
    {
        public StandardConfig()
        {
            HasKey(e => new { e.StandardId, e.Section });
        }
    }
}

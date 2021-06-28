using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public class Teacher
    {
        public Teacher()
        {
            Standards = new HashSet<Standard>();
        }
        public int TeacherId { get; set; }

        public string TeacherName { get; set; }

        public int StandardId { get; set; }

        public string Section { get; set; }

        public string SubjectName { get; set; }

        public virtual ICollection<Standard> Standards { get; set; }


    }
}

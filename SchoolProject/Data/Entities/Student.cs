using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace SchoolProject.Data.Entities
{
    public class Student
    {
        public Student()
        {
            FeeDetails = new HashSet<FeeDetail>();
        }
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public int StandardId { get; set; }

        public string Section { get; set; }

        public int Age { get; set; }

        public virtual StudentDetail StudentDetails { get; set; }

        public virtual ICollection<FeeDetail> FeeDetails { get; set; }

        public virtual Standard Standard { get; set; }

    }
    public class StudentConfig:EntityTypeConfiguration<Student>
    {
        public StudentConfig()
        {
            Property(e => e.StudentName).HasMaxLength(30);

            HasOptional(e => e.StudentDetails).WithRequired(e => e.Student);

            HasRequired(e => e.Standard).WithMany(e => e.Students).WillCascadeOnDelete(false);
        }
    }
}

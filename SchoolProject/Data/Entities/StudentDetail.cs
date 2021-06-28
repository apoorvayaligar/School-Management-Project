using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace SchoolProject.Data.Entities
{
    public class StudentDetail
    {
        
        public int StudentId { get; set; }

        public DateTime DOB { get; set; }

        public DateTime DOJ { get; set; }

        public string FatherName { get; set; }

        public string MotherName { get; set; }

        public string Address { get; set; }

        public string ParentMobileNo { get; set; }

        public virtual Student Student { get; set; }

    }
    public class StudentDetailConfig:EntityTypeConfiguration<StudentDetail>
    {
        public StudentDetailConfig()
        {
            HasKey(e => e.StudentId);
        }
    }
}

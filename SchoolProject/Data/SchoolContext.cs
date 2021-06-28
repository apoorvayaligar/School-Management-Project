using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SchoolProject.Data.Entities;

namespace SchoolProject.Data
{
    public class SchoolContext:DbContext
    {
        public SchoolContext():base("SchoolDB")
        {

        }
        protected override void OnModelCreating(DbModelBuilder Builder)
        {
            Builder.Configurations.Add(new StandardConfig());
            Builder.Configurations.Add(new StudentConfig());
            Builder.Configurations.Add(new StudentDetailConfig());


        }
        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Standard> Standards { get; set; }

        public virtual DbSet<StudentDetail> StudentDetails { get; set; }

        public virtual DbSet<FeeDetail> FeeDetails { get; set; }

        public virtual DbSet<Teacher> Teachers { get; set; }
    }
}

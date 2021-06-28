using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace SchoolProject.Data.Entities
{
    public class FeeDetail
    {
        public int FeeDetailId { get; set; }

        public int StudentId { get; set; }

        public int FeePaid { get; set; }

        public int FeeDue { get; set; }

        public virtual Student Student { get; set; }

    }
    public class FeeDetailConfig:EntityTypeConfiguration<FeeDetail>
    {
        public FeeDetailConfig()
        {
            HasIndex(e => e.StudentId).IsUnique();
        }
    }
}

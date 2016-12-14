using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Attendnce
    {
        [ForeignKey("Student")]
        public string StId { get; set; }
        public virtual Students Student { get; set; }

        public IEnumerable<bool> Days { get; set; }
    }

    public class AttendanceContext : DbContext
    {
        public DbSet<Attendnce> Attendance_Sheet { get; set; }
    }
}
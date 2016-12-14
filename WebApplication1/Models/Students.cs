using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{

    public class Students
    {
        [Key]
        public int StId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Father { get; set; }

        public string Class { get; set; }

        public string Section { get; set; }

        public string Gender { get; set; }

        [DataType(DataType.Date)]
        public string Admission_Date { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone_Number { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Father_Phone { get; set; }

        public string Address { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Students> Student_List { get; set; }
    }
}
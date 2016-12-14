using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Fee
    {
        [ForeignKey("Student")]
        public string StId { get; set; }
        public virtual Students Student { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public int Balance { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public int Tuition_Fee { get; set; }

        [DataType(DataType.Currency)]
        public int Additional_Fee { get; set; }

        public bool Paid { get; set; }
    }

    public class FeeContext : DbContext
    {
        public DbSet<Fee> Fee_Report { get; set; }
    }
}
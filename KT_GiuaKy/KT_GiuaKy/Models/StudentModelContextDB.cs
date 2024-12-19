using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace KT_GiuaKy.Models
{
    public partial class StudentModelContextDB : DbContext
    {
        public StudentModelContextDB()
            : base("name=StudentModelContextDB")
        {
        }

        public virtual DbSet<LOP> LOP { get; set; }
        public virtual DbSet<SINHVIEN> SINHVIEN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LOP>()
                .Property(e => e.MALOP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.MASV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.MALOP)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}


    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
namespace WikiCollege.Models.EF
{
    public partial class WikiCollegeDBContext : DbContext
    {
        public WikiCollegeDBContext()
            : base("name=WikiCollegeDBContext")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTS { get; set; }
        public virtual DbSet<COLLEGE> COLLEGE { get; set; }
        public virtual DbSet<COLLEGE_SAVED> COLLEGE_SAVED { get; set; }
        public virtual DbSet<COMMENT> COMMENT { get; set; }
        public virtual DbSet<CONTENT> CONTENT { get; set; }
        public virtual DbSet<CONTENT_SAVED> CONTENT_SAVED { get; set; }
        public virtual DbSet<MAJ_COLLEGE> MAJ_COLLEGE { get; set; }
        public virtual DbSet<MAJOR> MAJORs { get; set; }
        public virtual DbSet<MAJOR_SAVED> MAJOR_SAVED { get; set; }
        public virtual DbSet<NOTIFICATION> NOTIFICATIONs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.acc_type)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.user_name)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.pass_word)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .HasMany(e => e.COLLEGE_SAVED)
                .WithRequired(e => e.ACCOUNT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ACCOUNT>()
                .HasMany(e => e.MAJOR_SAVED)
                .WithRequired(e => e.ACCOUNT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COLLEGE>()
                .Property(e => e.college_code)
                .IsUnicode(false);

            modelBuilder.Entity<COLLEGE>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<COLLEGE>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<COLLEGE>()
                .Property(e => e.website)
                .IsUnicode(false);

            modelBuilder.Entity<COLLEGE>()
                .HasMany(e => e.COLLEGE_SAVED)
                .WithRequired(e => e.COLLEGE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COLLEGE>()
                .HasMany(e => e.MAJ_COLLEGE)
                .WithRequired(e => e.COLLEGE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COLLEGE_SAVED>()
                .Property(e => e.college_code)
                .IsUnicode(false);

            modelBuilder.Entity<CONTENT>()
                .Property(e => e.meta_title)
                .IsUnicode(false);

            modelBuilder.Entity<MAJ_COLLEGE>()
                .Property(e => e.college_code)
                .IsUnicode(false);

            modelBuilder.Entity<MAJ_COLLEGE>()
                .Property(e => e.major_code)
                .IsUnicode(false);

            modelBuilder.Entity<MAJOR>()
                .Property(e => e.major_code)
                .IsUnicode(false);

            modelBuilder.Entity<MAJOR>()
                .Property(e => e.group)
                .IsUnicode(false);

            modelBuilder.Entity<MAJOR>()
                .HasMany(e => e.MAJOR_SAVED)
                .WithRequired(e => e.MAJOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAJOR_SAVED>()
                .Property(e => e.major_code)
                .IsUnicode(false);
        }
    }
}

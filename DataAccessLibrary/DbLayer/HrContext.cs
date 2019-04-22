namespace DataAccessLibrary.DbLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HrContext : DbContext
    {
        public HrContext()
            : base("name=HrContext")
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmpPromotion> EmpPromotion { get; set; }
        public virtual DbSet<JobTitle> JobTitle { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.INN)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmpPromotion)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmpPromotion>()
                .Property(e => e.Salary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<JobTitle>()
                .HasMany(e => e.EmpPromotion)
                .WithRequired(e => e.JobTitle)
                .WillCascadeOnDelete(false);
        }

        public System.Data.Entity.DbSet<EmpPromotion> EmpPromotiones { get; set; }
    }
}

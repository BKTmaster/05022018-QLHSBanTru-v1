namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLHSDbContext : DbContext
    {
        public QLHSDbContext()
            : base("name=QLHSDbContext")
        {
        }

        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<DailyTask> DailyTasks { get; set; }
        public virtual DbSet<Degree> Degrees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee_Class> Employee_Class { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student_Class> Student_Class { get; set; }
        public virtual DbSet<StudentParent> StudentParents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.IdentityNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentCode)
                .IsFixedLength();

            modelBuilder.Entity<StudentParent>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<StudentParent>()
                .Property(e => e.FatherPhone)
                .IsUnicode(false);

            modelBuilder.Entity<StudentParent>()
                .Property(e => e.MotherPhone)
                .IsUnicode(false);
        }
    }
}

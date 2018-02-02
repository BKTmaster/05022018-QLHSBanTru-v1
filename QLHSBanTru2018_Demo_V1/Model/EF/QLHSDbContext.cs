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
        public virtual DbSet<DailyMenu> DailyMenus { get; set; }
        public virtual DbSet<DailyMenuDetail> DailyMenuDetails { get; set; }
        public virtual DbSet<DailyTask> DailyTasks { get; set; }
        public virtual DbSet<Degree> Degrees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Dish> Dishes { get; set; }
        public virtual DbSet<DishDetail> DishDetails { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee_Class> Employee_Class { get; set; }
        public virtual DbSet<EthnicGroup> EthnicGroups { get; set; }
        public virtual DbSet<FoodGroup> FoodGroups { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<HealthExamination> HealthExaminations { get; set; }
        public virtual DbSet<HealthExaminationDetail> HealthExaminationDetails { get; set; }
        public virtual DbSet<HealthProblem> HealthProblems { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<IngredientType> IngredientTypes { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<MonthlyTask> MonthlyTasks { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Receivable> Receivables { get; set; }
        public virtual DbSet<Receivable_Student> Receivable_Student { get; set; }
        public virtual DbSet<ReceivableDetail> ReceivableDetails { get; set; }
        public virtual DbSet<Religion> Religions { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student_Class> Student_Class { get; set; }
        public virtual DbSet<Student_Lesson> Student_Lesson { get; set; }
        public virtual DbSet<StudentParent> StudentParents { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<TopicType> TopicTypes { get; set; }
        public virtual DbSet<WeeklyMenu> WeeklyMenus { get; set; }
        public virtual DbSet<WeeklyTask> WeeklyTasks { get; set; }

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

            modelBuilder.Entity<Ingredient>()
                .Property(e => e.PriceOfUnit)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ReceivableDetail>()
                .Property(e => e.Proceeds)
                .HasPrecision(18, 0);

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

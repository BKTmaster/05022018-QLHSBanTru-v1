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
        public virtual DbSet<CourseTask> CourseTasks { get; set; }
        public virtual DbSet<DailyMenu> DailyMenus { get; set; }
        public virtual DbSet<DailyMenuDetail> DailyMenuDetails { get; set; }
        public virtual DbSet<DailyTask> DailyTasks { get; set; }
        public virtual DbSet<Degree> Degrees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Dish> Dishes { get; set; }
        public virtual DbSet<DishDetail> DishDetails { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee_Class> Employee_Class { get; set; }
        public virtual DbSet<Employee_Function> Employee_Function { get; set; }
        public virtual DbSet<EthnicGroup> EthnicGroups { get; set; }
        public virtual DbSet<FoodGroup> FoodGroups { get; set; }
        public virtual DbSet<Function> Functions { get; set; }
        public virtual DbSet<FunctionGroup> FunctionGroups { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<HealthExamination> HealthExaminations { get; set; }
        public virtual DbSet<HealthExaminationDetail> HealthExaminationDetails { get; set; }
        public virtual DbSet<HealthProblem> HealthProblems { get; set; }
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<IngredientType> IngredientTypes { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<PhysicalMonthlyTask> PhysicalMonthlyTasks { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Preferred> Preferreds { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Receivable> Receivables { get; set; }
        public virtual DbSet<ReceivableDetail> ReceivableDetails { get; set; }
        public virtual DbSet<ReceivableDetail_Preferred> ReceivableDetail_Preferred { get; set; }
        public virtual DbSet<ReceivableDetail_Student> ReceivableDetail_Student { get; set; }
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
            modelBuilder.Entity<Class>()
                .HasMany(e => e.Employee_Class)
                .WithRequired(e => e.Class)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Class>()
                .HasMany(e => e.Student_Class)
                .WithRequired(e => e.Class)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.CourseTasks)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Semesters)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DailyMenu>()
                .HasMany(e => e.DailyMenuDetails)
                .WithRequired(e => e.DailyMenu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Contracts)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Dish>()
                .HasMany(e => e.DailyMenuDetails)
                .WithRequired(e => e.Dish)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Dish>()
                .HasMany(e => e.DishDetails)
                .WithRequired(e => e.Dish)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<District>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.District)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<District>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.District)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.IdentityNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Contracts)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Employee_Class)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Employee_Function)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.HealthProblems)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EthnicGroup>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.EthnicGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Function>()
                .HasMany(e => e.Employee_Function)
                .WithRequired(e => e.Function)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FunctionGroup>()
                .HasMany(e => e.Functions)
                .WithRequired(e => e.FunctionGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Grade>()
                .HasMany(e => e.Classes)
                .WithRequired(e => e.Grade)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HealthExamination>()
                .HasMany(e => e.HealthExaminationDetails)
                .WithRequired(e => e.HealthExamination)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ingredient>()
                .HasMany(e => e.DishDetails)
                .WithRequired(e => e.Ingredient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ingredient>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Ingredient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IngredientType>()
                .HasMany(e => e.Ingredients)
                .WithRequired(e => e.IngredientType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lesson>()
                .HasMany(e => e.Student_Lesson)
                .WithRequired(e => e.Lesson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Meal>()
                .HasMany(e => e.DailyMenuDetails)
                .WithRequired(e => e.Meal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.PriceOfUnit)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PhysicalMonthlyTask>()
                .HasMany(e => e.DailyTasks)
                .WithRequired(e => e.PhysicalMonthlyTask)
                .HasForeignKey(e => e.MonthlyTaskID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Position>()
                .HasMany(e => e.Contracts)
                .WithRequired(e => e.Position)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Preferred>()
                .HasMany(e => e.ReceivableDetail_Preferred)
                .WithRequired(e => e.Preferred)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receivable>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Receivable>()
                .HasMany(e => e.ReceivableDetails)
                .WithRequired(e => e.Receivable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReceivableDetail>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ReceivableDetail>()
                .Property(e => e.SalePrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ReceivableDetail>()
                .HasMany(e => e.ReceivableDetail_Preferred)
                .WithRequired(e => e.ReceivableDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReceivableDetail>()
                .HasMany(e => e.ReceivableDetail_Student)
                .WithRequired(e => e.ReceivableDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Religion>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Religion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Semester>()
                .HasMany(e => e.Grades)
                .WithRequired(e => e.Semester)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentCode)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .HasMany(e => e.CourseTasks)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.DailyTasks)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.HealthExaminationDetails)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.HealthProblems)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.ReceivableDetail_Student)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Student_Class)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Student_Lesson)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.StudentParents)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StudentParent>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<StudentParent>()
                .Property(e => e.FatherPhone)
                .IsUnicode(false);

            modelBuilder.Entity<StudentParent>()
                .Property(e => e.MotherPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Topic>()
                .HasMany(e => e.Lessons)
                .WithRequired(e => e.Topic)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TopicType>()
                .HasMany(e => e.Topics)
                .WithRequired(e => e.TopicType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WeeklyMenu>()
                .HasMany(e => e.DailyMenus)
                .WithRequired(e => e.WeeklyMenu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WeeklyTask>()
                .HasMany(e => e.DailyTasks)
                .WithRequired(e => e.WeeklyTask)
                .WillCascadeOnDelete(false);
        }
    }
}

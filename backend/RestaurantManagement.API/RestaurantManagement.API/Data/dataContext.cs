using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.API.Enums;
using RestaurantManagement.API.Models;

namespace RestaurantManagement.API.Data
{
    public class DataContext : IdentityDbContext<Employee>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<Week> Weeks { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Config> Configs { get; set; }
        public virtual DbSet<ShiftSelectionTemplate> ShiftSelectionTemplates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the one-to-many relationship between Employee and Shift
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Shifts)
                .WithOne(s => s.Employee)
                .HasForeignKey(s => s.EmployeeId);

            // Configure the required properties for Shift
            modelBuilder.Entity<Shift>()
                .Property(s => s.StartHour)
                .IsRequired();

            modelBuilder.Entity<Shift>()
                .Property(s => s.EndHour)
                .IsRequired();

            modelBuilder.Entity<Shift>()
                .Property(s => s.Type)
                .IsRequired();

            modelBuilder.Entity<Shift>()
                .Property(s => s.Status)
                .IsRequired();

            // Configure the required properties for Week
            modelBuilder.Entity<Week>()
                .Property(w => w.StartDate)
                .IsRequired();

            modelBuilder.Entity<Week>()
                .Property(w => w.EndDate)
                .IsRequired();

            modelBuilder.Entity<Week>()
                .Property(w => w.RowVersion)
                .IsRowVersion();

            // Configure the required properties for Employee
            modelBuilder.Entity<Employee>()
                .Property(e => e.Type)
                .IsRequired();

            modelBuilder.Entity<Employee>()
                .Property(e => e.FullName)
                .IsRequired();

            modelBuilder.Entity<Employee>()
                .Property(e => e.IsManager)
                .IsRequired();

            // Configure the one-to-many relationship between Config and ShiftSelectionTemplate
            modelBuilder.Entity<Config>()
                .HasMany(c => c.ShiftSelectionTemplates)
                .WithOne(s => s.Config)
                .HasForeignKey(s => s.ConfigID)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure the one-to-one relationship between ShiftSelectionTemplate and Config
            modelBuilder.Entity<ShiftSelectionTemplate>()
                .HasOne(s => s.Config)
                .WithMany(c => c.ShiftSelectionTemplates)
                .HasForeignKey(s => s.ConfigID);

            SeedData(modelBuilder);
        }



        private void SeedData(ModelBuilder modelBuilder)
        {
            DateTime startDate = new DateTime(2024, 6, 9);
            DateTime endDate = startDate.AddMonths(6);

            var weeks = new List<Week>();
            var shifts = new List<Shift>();
            int shiftId = 1;
            int weekId = 1;

            for (DateTime date = startDate; date < endDate; date = date.AddDays(7))
            {
                Week week = new Week()
                {
                    ID = weekId,
                    StartDate = date,
                    EndDate = date.AddDays(6),
                    WeekStatus = WeekStatus.Open,
                };

                weeks.Add(week);

                for (int i = 0; i < 14; i++)
                {
                    DateTime shiftDate = date.AddDays(i % 7);
                    bool isMorningShift = i < 7;

                    shifts.Add(new Shift
                    {
                        ID = shiftId++,
                        Subject = isMorningShift ? "Morning Shift" : "Evening Shift",
                        StartHour = isMorningShift ? new DateTime(shiftDate.Year, shiftDate.Month, shiftDate.Day, 8, 0, 0) : new DateTime(shiftDate.Year, shiftDate.Month, shiftDate.Day, 16, 0, 0),
                        EndHour = isMorningShift ? new DateTime(shiftDate.Year, shiftDate.Month, shiftDate.Day, 16, 0, 0) : new DateTime(shiftDate.Year, shiftDate.Month, shiftDate.Day, 23, 0, 0),
                        IsTicked = false,
                        Type = EmployeeType.Waiter,
                        Status = ShiftStatus.template,
                        WeekId = week.ID
                    });

                    // Create a duplicate shift with Status = ShiftStatus.EditedByManager for the third week (weekId == 3)
                    if (weekId == 3)
                    {
                        shifts.Add(new Shift
                        {
                            ID = shiftId++,
                            Subject = isMorningShift ? "Morning Shift" : "Evening Shift",
                            StartHour = isMorningShift ? new DateTime(shiftDate.Year, shiftDate.Month, shiftDate.Day, 8, 0, 0) : new DateTime(shiftDate.Year, shiftDate.Month, shiftDate.Day, 16, 0, 0),
                            EndHour = isMorningShift ? new DateTime(shiftDate.Year, shiftDate.Month, shiftDate.Day, 16, 0, 0) : new DateTime(shiftDate.Year, shiftDate.Month, shiftDate.Day, 23, 0, 0),
                            IsTicked = true,
                            Type = EmployeeType.Waiter,
                            Status = ShiftStatus.EditedByManager,
                            WeekId = week.ID,
                            EmployeeId = "1"
                        });

                        shifts.Add(new Shift
                        {
                            ID = shiftId++,
                            Subject = isMorningShift ? "Morning Shift" : "Evening Shift",
                            StartHour = isMorningShift ? new DateTime(shiftDate.Year, shiftDate.Month, shiftDate.Day, 8, 0, 0) : new DateTime(shiftDate.Year, shiftDate.Month, shiftDate.Day, 16, 0, 0),
                            EndHour = isMorningShift ? new DateTime(shiftDate.Year, shiftDate.Month, shiftDate.Day, 16, 0, 0) : new DateTime(shiftDate.Year, shiftDate.Month, shiftDate.Day, 23, 0, 0),
                            IsTicked = true,
                            Type = EmployeeType.Waiter,
                            Status = ShiftStatus.EditedByManager,
                            WeekId = week.ID,
                            EmployeeId = "2"
                        });

                        shifts.Add(new Shift
                        {
                            ID = shiftId++,
                            Subject = isMorningShift ? "Morning Shift" : "Evening Shift",
                            StartHour = isMorningShift ? new DateTime(shiftDate.Year, shiftDate.Month, shiftDate.Day, 8, 0, 0) : new DateTime(shiftDate.Year, shiftDate.Month, shiftDate.Day, 16, 0, 0),
                            EndHour = isMorningShift ? new DateTime(shiftDate.Year, shiftDate.Month, shiftDate.Day, 16, 0, 0) : new DateTime(shiftDate.Year, shiftDate.Month, shiftDate.Day, 23, 0, 0),
                            IsTicked = true,
                            Type = EmployeeType.Waiter,
                            Status = ShiftStatus.Submitted,
                            WeekId = week.ID,
                            EmployeeId = "1"
                        });

                        shifts.Add(new Shift
                        {
                            ID = shiftId++,
                            Subject = isMorningShift ? "Morning Shift" : "Evening Shift",
                            StartHour = isMorningShift ? new DateTime(shiftDate.Year, shiftDate.Month, shiftDate.Day, 8, 0, 0) : new DateTime(shiftDate.Year, shiftDate.Month, shiftDate.Day, 16, 0, 0),
                            EndHour = isMorningShift ? new DateTime(shiftDate.Year, shiftDate.Month, shiftDate.Day, 16, 0, 0) : new DateTime(shiftDate.Year, shiftDate.Month, shiftDate.Day, 23, 0, 0),
                            IsTicked = true,
                            Type = EmployeeType.Waiter,
                            Status = ShiftStatus.Submitted,
                            WeekId = week.ID,
                            EmployeeId = "2"
                        });
                    }
                }

                weekId++;
            }

            modelBuilder.Entity<Week>().HasData(weeks);
            modelBuilder.Entity<Shift>().HasData(shifts);

            // Seed dummy employees
            var passwordHasher = new PasswordHasher<Employee>();
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = "1", FullName = "Avi", UserName = "waiter1", NormalizedUserName = "WAITER1", Email = "waiter1@example.com", NormalizedEmail = "WAITER1@EXAMPLE.COM", EmailConfirmed = true, PasswordHash = passwordHasher.HashPassword(null, "Password1!"), SecurityStamp = string.Empty, Type = EmployeeType.Waiter, IsManager = false },
                new Employee { Id = "2", FullName = "Natan", UserName = "waiter2", NormalizedUserName = "WAITER2", Email = "waiter2@example.com", NormalizedEmail = "WAITER2@EXAMPLE.COM", EmailConfirmed = true, PasswordHash = passwordHasher.HashPassword(null, "Password2!"), SecurityStamp = string.Empty, Type = EmployeeType.Waiter, IsManager = false },
                new Employee { Id = "3", FullName = "Savarinovvvvv", UserName = "waiter3", NormalizedUserName = "WAITER3", Email = "waiter3@example.com", NormalizedEmail = "WAITER3@EXAMPLE.COM", EmailConfirmed = true, PasswordHash = passwordHasher.HashPassword(null, "Password3!"), SecurityStamp = string.Empty, Type = EmployeeType.Waiter, IsManager = true },
                new Employee { Id = "4", FullName = "Tal Withlastname", UserName = "waiter4", NormalizedUserName = "WAITER4", Email = "waiter4@example.com", NormalizedEmail = "WAITER4@EXAMPLE.COM", EmailConfirmed = true, PasswordHash = passwordHasher.HashPassword(null, "Password4!"), SecurityStamp = string.Empty, Type = EmployeeType.Waiter, IsManager = true }
            );

            // Seed dummy ShiftSelectionTemplates
            var shiftSelectionTemplates = new List<ShiftSelectionTemplate>
    {
        new ShiftSelectionTemplate { ID = 1, Name = "משמרת בוקר קצרה", StartHour = 8, StartMin = 0, EndHour = 12, EndMin = 0, ConfigID = null },
        new ShiftSelectionTemplate { ID = 2, Name = "משמרת בוקר צהריים", StartHour = 8, StartMin = 0, EndHour = 16, EndMin = 0, ConfigID = null },
        new ShiftSelectionTemplate { ID = 3, Name = "משמרת ערב קצרה", StartHour = 16, StartMin = 0, EndHour = 20, EndMin = 0, ConfigID = null },
        new ShiftSelectionTemplate { ID = 4, Name = "משמרת ערב ", StartHour = 16, StartMin = 0, EndHour = 23, EndMin = 0, ConfigID = null }
    };

            modelBuilder.Entity<ShiftSelectionTemplate>().HasData(shiftSelectionTemplates);
        }




    }
}
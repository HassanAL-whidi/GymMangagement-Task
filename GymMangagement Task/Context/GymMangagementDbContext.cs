using gym_management.Models.Entites;
using gym_management.Models.EntiteyConfiguration;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace gym_management.Context
{
    public class GymMangagementDbContext : DbContext
    {

        public GymMangagementDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EmployeeDepartment>().Property(e => e.EmployeeId).IsRequired();
            modelBuilder.Entity<EmployeeDepartment>().HasKey(e => e.Id);
            modelBuilder.Entity<EmployeeDepartment>().Property(e => e.DepartmentId).IsRequired();
            modelBuilder.Entity<ClientCoach>().Property(e => e.ClientId).IsRequired();
            modelBuilder.Entity<ClientCoach>().HasKey(e => e.Id);
            modelBuilder.Entity<ClientCoach>().Property(e => e.CoachId).IsRequired();
            modelBuilder.Entity<SubscriptionCoach>().Property(e => e.SubscriptionId).IsRequired();
            modelBuilder.Entity<SubscriptionCoach>().HasKey(e => e.Id);
            modelBuilder.Entity<ClientCoach>().Property(e => e.CoachId).IsRequired();

            modelBuilder.ApplyConfiguration(new AdminConfigurations());
            modelBuilder.ApplyConfiguration(new ClientConfigurations());
            modelBuilder.ApplyConfiguration(new CoachConfigurations());
            modelBuilder.ApplyConfiguration(new DepartmentConfigurations());
            modelBuilder.ApplyConfiguration(new EmployeeConfigurations());
            modelBuilder.ApplyConfiguration(new SubscriptionConfigurations());




        }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientCoach> ClientCoaches { get; set; }
        public virtual DbSet<Coach> Coaches { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeDepartment> EmployeeDepartments { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<SubscriptionCoach> SubscriptionCoaches { get; set; }
        public virtual DbSet<User> Users { get; set; }


    }
}

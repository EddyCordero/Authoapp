using System;
using Authoapp.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Authoapp.API.DbContexts
{
    public class AuthoappDbContext : DbContext
    {
        public AuthoappDbContext(DbContextOptions<AuthoappDbContext> options) : base(options) { }

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PermissionType>().HasData(
                new PermissionType() {
                    Id=1,
                    Description = "Vacaciones"
                },
                new PermissionType()
                {
                    Id = 2,
                    Description = "Licencia"
                },
                new PermissionType()
                {
                    Id = 3,
                    Description = "Enfermedad"
                });

            modelBuilder.Entity<Permission>().HasData(
                new Permission {
                    Id = 1,
                    FirstName = "Juan",
                    LastName  = "Perez",
                    PermissionTypeId = 1,
                    DateFrom = DateTimeOffset.Now,
                    DateTo = DateTime.Today.AddDays(15)
                },
                new Permission
                {
                    Id= 2,
                    FirstName = "Maria",
                    LastName = "Perez",
                    PermissionTypeId = 2,
                    DateFrom = DateTimeOffset.Now,
                    DateTo = DateTime.Today.AddDays(1)
                }
                );
            base.OnModelCreating(modelBuilder);
        }

     }
}

using DAL.Generators;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
            .HasOne(p => p.User)
            .WithMany(b => b.Orders)
            .HasForeignKey(p => p.UserId);

            modelBuilder.Seed();
        }
    }
}

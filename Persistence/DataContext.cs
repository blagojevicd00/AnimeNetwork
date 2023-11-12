using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UsersRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<EpisodeRating> EpisodeRatings { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EpisodeRating>(x => x.HasKey(er => new { er.EpisodeId, er.RatingId }));

            modelBuilder.Entity<EpisodeRating>()
                .HasOne(er => er.Episode)
                .WithMany(c => c.EpisodeRatings)
                .HasForeignKey(er => er.EpisodeId);

            modelBuilder.Entity<EpisodeRating>()
                .HasOne(er => er.Rating)
                .WithMany(s => s.EpisodeRatings)
                .HasForeignKey(er => er.RatingId);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserRole>(x => x.HasKey(er => new { er.UserId, er.RoleId }));

            modelBuilder.Entity<UserRole>()
                .HasOne(er => er.User)
                .WithMany(c => c.UserRoles)
                .HasForeignKey(er => er.UserId);

            modelBuilder.Entity<UserRole>()
                .HasOne(er => er.Role)
                .WithMany(s => s.UserRoles)
                .HasForeignKey(er => er.RoleId);
        }
    }
}

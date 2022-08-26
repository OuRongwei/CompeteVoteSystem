using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VoteSystem.Model;

namespace VoteSystem.Dal
{
    public class TPContext : DbContext
    {
        public TPContext(DbContextOptions<TPContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>();

            modelBuilder.Entity<Compete>();

            modelBuilder.Entity<Singer>();

            modelBuilder.Entity<User>();

            // 多对多关系映射
            modelBuilder.Entity<CompeteAndSinger>(entity =>
            {
                entity.HasOne(c => c.Singer).WithMany(c => c.CompeteAndSingers).HasForeignKey(c => c.SingerId);
                entity.HasOne(c => c.Compete).WithMany(c => c.CompeteAndSingers).HasForeignKey(c => c.CompeteId);
            });

            // 多对多映射
            modelBuilder.Entity<VoteList>(entity =>
            {
                entity.HasOne(c => c.User).WithMany(c => c.VoteLists).HasForeignKey(c => c.UserId);
                entity.HasOne(c => c.Singer).WithMany(c => c.VoteLists).HasForeignKey(c => c.SingerId);
                entity.HasOne(c => c.Compete).WithMany(c => c.VoteLists).HasForeignKey(c => c.CompeteId);
            });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Compete> Competes { get; set; }

        public DbSet<CompeteAndSinger> CompeteAndSingers { get; set; }

        public DbSet<Singer> Singers { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<VoteList> voteLists { get; set; }

    }
}

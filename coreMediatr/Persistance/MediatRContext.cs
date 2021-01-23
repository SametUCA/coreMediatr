using coreMediatr.Models;
using Microsoft.EntityFrameworkCore;

namespace coreMediatr.Persistance
{
    public class MediatRContext : DbContext
    {
        public MediatRContext(DbContextOptions<MediatRContext> options) : base(options)
        {
             
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().HasData(
                new Article
                {
                    Id = 1,
                    Name = "Test01"
                },
                new Article
                {
                    Id = 2,
                    Name = "Test02"
                },
                new Article
                {
                    Id = 3,
                    Name = "Test03"
                }
            );
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Article> Articles { get; set; }
    }
    
}
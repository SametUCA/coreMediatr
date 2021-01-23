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
                    Name = "Samet"
                },
                new Article
                {
                    Id = 2,
                    Name = "Samet"
                },
                new Article
                {
                    Id = 3,
                    Name = "Samet"
                }
            );
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Article> Articles { get; set; }
    }
    
}
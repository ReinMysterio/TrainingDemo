
using Microsoft.EntityFrameworkCore;
using TrainingDemo.DataAccess.Entities;

namespace TraininingDemo.DataAccess
{
    public class TrainingDemoDbContext : DbContext
    {
        public TrainingDemoDbContext(DbContextOptions<TrainingDemoDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
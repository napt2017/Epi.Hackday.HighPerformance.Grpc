using DB.Access.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DB.Access
{
    public class EpiHackdayDbContext : DbContext
    {
        public EpiHackdayDbContext(DbContextOptions<EpiHackdayDbContext> dbContextOptions): base(dbContextOptions)
        {

        }

        public DbSet<HackdayTopic> HackdayTopics { get; set; }
    }

    public class EpiHackdayDbContextFactory : IDesignTimeDbContextFactory<EpiHackdayDbContext>
    {
        public EpiHackdayDbContext CreateDbContext(string[] args) => new EpiHackdayDbContext(DbContextOptions());

        private DbContextOptions<EpiHackdayDbContext> DbContextOptions() => 
            new DbContextOptionsBuilder<EpiHackdayDbContext>().UseSqlite("Data Source=D:\\db\\hackday.db").Options;
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogApplication.DataAccess.DataAccessLogApplication
{
    public  class LogApplicationDbContext : DbContext
    {
        public LogApplicationDbContext(DbContextOptions<LogApplicationDbContext> options) : base(options) { }


        //Entidades
        public DbSet<LogApplicationDto> LogAplicaciones { get; set; }

        public class YourDbContextFactory : IDesignTimeDbContextFactory<LogApplicationDbContext>
        {
            public LogApplicationDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<LogApplicationDbContext>();
                optionsBuilder.UseSqlServer("Server=(localdb)\\itsense;Database=opain;Trusted_Connection=True");

                return new LogApplicationDbContext(optionsBuilder.Options);
            }
        }
    }
}

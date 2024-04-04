using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogApplication.DataAccess.DataAccessLogApplication
{
    public  class LogApplicationDbContext : DbContext
    {
        public LogApplicationDbContext(DbContextOptions options) : base(options) { }


        //Entidades
        public DbSet<LogApplicationDto> LogAplicaciones { get; set; }
    }
}

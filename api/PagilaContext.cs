using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace api
{
    public class PagilaContext:DbContext
    {
        public PagilaContext(DbContextOptions<PagilaContext> options):base(options) {  }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}
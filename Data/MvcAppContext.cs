using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcApp.Data
{
    public class MvcAppContext : DbContext
    {
        public MvcAppContext (DbContextOptions<MvcAppContext> options)
            : base(options)
        {
        }

        public DbSet<MvcApp.Models.Movie> Movie { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VentaDeLotes.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    public class DataContext:DbContext
    {
        public DbSet<Ground> Grounds { get; set; }
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
    }
}

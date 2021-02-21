using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Week7Assignment.Models;

namespace Week7Assignment.Data
{
    public class Week7AssignmentContext : DbContext
    {
        public Week7AssignmentContext (DbContextOptions<Week7AssignmentContext> options)
            : base(options)
        {
        }

        public DbSet<Week7Assignment.Models.Entry> Entry { get; set; }
    }
}

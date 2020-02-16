using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPLearning.Models;

namespace ASPLearning.Data
{
    public class ASPLearningContext : DbContext
    {
        public ASPLearningContext (DbContextOptions<ASPLearningContext> options)
            : base(options)
        {
        }

        public DbSet<ASPLearning.Models.Movie> Movie { get; set; }
    }
}

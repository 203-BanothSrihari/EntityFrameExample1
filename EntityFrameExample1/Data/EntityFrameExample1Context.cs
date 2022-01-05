using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityFrameExample1.Models;

namespace EntityFrameExample1.Data
{
    public class EntityFrameExample1Context : DbContext
    {
        public EntityFrameExample1Context (DbContextOptions<EntityFrameExample1Context> options)
            : base(options)
        {
        }

        public DbSet<EntityFrameExample1.Models.Employee> Employee { get; set; }
    }
}

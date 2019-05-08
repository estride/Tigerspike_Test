
namespace TigerSpike.Data
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TigerSpike.Entities.Models;

    public class TSContext : DbContext
    {
        public TSContext(DbContextOptions<TSContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);         
        }

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Screen> ScreenTimings { get; set; }
    }
}

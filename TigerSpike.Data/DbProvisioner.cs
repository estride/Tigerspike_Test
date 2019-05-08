using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace TigerSpike.Data
{
    public class DbProvisioner
    {
    
        public DbProvisioner()
        {
            
        }

        public void ProvisionDatabase(string connectionString)
        {
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<TSContext>();

            dbContextOptionsBuilder.UseSqlServer(connectionString, opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds));

            using (var dbContext = new TSContext(dbContextOptionsBuilder.Options))
            {
                dbContext.Database.Migrate();
            }            
        }
    }
}

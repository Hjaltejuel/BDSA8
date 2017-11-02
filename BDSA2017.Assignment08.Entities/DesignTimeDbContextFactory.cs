using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BDSA2017.Assignment08.Entities
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SlotCarContext>
    {
        public SlotCarContext CreateDbContext(string[] args)
        {
            var connectionString = @"Data Source=slotcars.db";

            var builder = new DbContextOptionsBuilder<SlotCarContext>();
            builder.UseSqlite(connectionString);

            return new SlotCarContext(builder.Options);
        }
    }
}

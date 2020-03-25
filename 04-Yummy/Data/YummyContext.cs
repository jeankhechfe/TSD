using Microsoft.EntityFrameworkCore;
using Yummy.Models;

namespace Yummy.Data
{
    public class YummyContext : DbContext
    {
        public YummyContext(DbContextOptions<YummyContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipe { get; set; }
    }
}
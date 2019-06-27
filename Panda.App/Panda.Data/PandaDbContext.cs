using Microsoft.EntityFrameworkCore;
using Panda.Domain;

namespace Panda.Data
{
    public class PandaDbContext : DbContext
    {
        public PandaDbContext(DbContextOptions<PandaDbContext> options) : base(options)
        {
        }
    }
}

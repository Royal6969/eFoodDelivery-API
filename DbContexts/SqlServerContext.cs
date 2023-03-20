using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eFoodDelivery_API.DbContexts
{
    public class SqlServerContext : IdentityDbContext
    {
        public SqlServerContext(DbContextOptions options) : base(options)
        {
        }
    }
}

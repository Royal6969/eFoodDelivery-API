using eFoodDelivery_API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eFoodDelivery_API.DbContexts
{
    public class SqlServerContext : IdentityDbContext<ApplicationUser>
    {
        // contructor needed for context
        public SqlServerContext(DbContextOptions options) : base(options)
        {
        }

        // navigation properties for entities (also it creates the tables)
        public DbSet<ApplicationUser> ApplicationUsersDbSet { get; set; }
        public DbSet<Product> ProductsDbSet { get; set; }

        // overrriding the OnModelCreating() method for customize our entities (tables)
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserEntityConfiguration());
            builder.HasDefaultSchema("dlk_efooddelivery_api");

            builder.Entity<ApplicationUser>().ToTable("dlk_users");
            builder.Entity<IdentityRole>().ToTable("dlk_roles");
            builder.Entity<IdentityUserRole<string>>().ToTable("dlk_user_roles");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("dlk_role_claim");
            builder.Entity<IdentityUserClaim<string>>().ToTable("dlk_user_claim");
            builder.Entity<IdentityUserLogin<string>>().ToTable("dlk_user_login");
            builder.Entity<IdentityUserToken<string>>().ToTable("dlk_user_tokens");
        }
    }
}

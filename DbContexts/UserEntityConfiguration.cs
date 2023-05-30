using eFoodDelivery_API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace eFoodDelivery_API.DbContexts
{
    // here we have to add the extra fields for the user in ApplicationUser to can apply then finally
    public class UserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(user => user.Name).HasMaxLength(20); // to define a name for the user
            builder.Property(user => user.Code).HasMaxLength(6);  // to generate a code for recover password
        }
    }
}

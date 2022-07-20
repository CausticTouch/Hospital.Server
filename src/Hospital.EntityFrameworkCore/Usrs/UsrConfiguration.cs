using Hospital.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Hospital.Users
{
    public class UsrConfiguration : IEntityTypeConfiguration<Usr>
    {
        public void Configure(EntityTypeBuilder<Usr> builder)
        {
            builder.ToTable("Users");

            builder.ConfigureByConvention();

        }
    }
}

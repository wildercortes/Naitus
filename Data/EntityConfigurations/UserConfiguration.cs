using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Rut)
             .IsRequired(true);

            builder.Property(x => x.Name)
             .HasMaxLength(50)
             .IsRequired(true);

            builder.Property(x => x.LastName)
             .HasMaxLength(50)
             .IsRequired(true);

            builder.Property(x => x.Email)
             .HasMaxLength(50)
             .IsRequired(true);

            builder.Property(x => x.Password)
             .HasMaxLength(50)
             .IsRequired(true);

            builder.Property(x => x.BirthDate)
             .IsRequired(true);
        }
    }
}

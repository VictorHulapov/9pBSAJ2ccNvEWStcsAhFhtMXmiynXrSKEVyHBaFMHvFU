using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using SyRetail.Core.Domain;

namespace SyRetail.Data.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(p => p.CountryId)
                .IsRequired();

            builder.HasOne(h => h.Country)
                .WithMany()
                .HasForeignKey(h => h.CountryId);

            builder.HasOne(h => h.State)
                .WithMany()
                .HasForeignKey(h => h.StateId);
        }
    }
}

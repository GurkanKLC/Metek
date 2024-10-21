using Metek.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Metek.Persistence.EntityConfigurations
{
    public class MesaiConfiguration : IEntityTypeConfiguration<Mesai>
    {
        public void Configure(EntityTypeBuilder<Mesai> builder)
        {
            builder.ToTable("Mesai");

            builder.HasKey(b => b.Id);

        }
    }

}

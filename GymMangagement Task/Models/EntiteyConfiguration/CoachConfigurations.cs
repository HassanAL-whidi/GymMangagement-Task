using gym_management.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gym_management.Models.EntiteyConfiguration
{
    public class CoachConfigurations : IEntityTypeConfiguration<Coach>

    {
        public void Configure(EntityTypeBuilder<Coach> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).UseIdentityColumn();
        }
    }
}


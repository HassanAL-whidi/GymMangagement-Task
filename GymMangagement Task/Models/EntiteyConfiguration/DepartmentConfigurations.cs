using gym_management.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gym_management.Models.EntiteyConfiguration
{
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>

    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).UseIdentityColumn();
        }
    }
}

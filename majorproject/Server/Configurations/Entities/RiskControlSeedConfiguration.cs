using majorproject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace majorproject.Server.Configurations.Entities
{
    public class RiskControlSeedConfiguration : IEntityTypeConfiguration<RiskControl>
    {
        public void Configure(EntityTypeBuilder<RiskControl> builder)
        {
            builder.HasData(
                new RiskControl
                {
                    Id = 1,



                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new RiskControl
                {
                    Id = 2,



                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}

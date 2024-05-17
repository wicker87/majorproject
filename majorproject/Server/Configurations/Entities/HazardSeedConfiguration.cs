using majorproject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace majorproject.Server.Configurations.Entities
{
    public class HazardSeedConfiguration : IEntityTypeConfiguration<Hazard>
    {
        public void Configure(EntityTypeBuilder<Hazard> builder)
        {
            builder.HasData(
                new Hazard
                {
                    Id = 1,



                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Hazard
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

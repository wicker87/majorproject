using majorproject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace majorproject.Server.Configurations.Entities
{
    public class RAFSeedConfiguration : IEntityTypeConfiguration<RAF>
    {
        public void Configure(EntityTypeBuilder<RAF> builder)
        {
            builder.HasData(
                new RAF
                {
                    Id = 1,

                    Department = "Manufacturing",
                    Process = "Assembly Line Production",
                    Location = "Factory",
                    AssessmentDate = new DateTime(2024, 4, 17),
                    LastReviewDate = new DateTime(2024, 4, 18),
                    NextReviewDate = new DateTime(2027, 4, 18),
                   

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}

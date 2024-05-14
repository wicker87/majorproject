using majorproject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace majorproject.Server.Configurations.Entities
{
    public class ActivitySeedConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.HasData(
                new Activity
                {
                    Id = 1,

                    WorkActivity = "Machine operation",
                    FormId = 1,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Activity
                {
                    Id = 2,

                    WorkActivity = "Lifting, carrying, pushing, or pulling heavy objects",
                    FormId = 1,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Activity
                {
                    Id = 3,

                    WorkActivity = "Repetitive movements (e.g., assembly line work)",
                    FormId = 1,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Activity
                {
                    Id = 4,

                    WorkActivity = "Awkward postures (e.g., bending, twisting)",
                    FormId = 1,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}

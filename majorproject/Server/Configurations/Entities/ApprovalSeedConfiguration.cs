using majorproject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace majorproject.Server.Configurations.Entities
{
    public class ApprovalSeedConfiguration : IEntityTypeConfiguration<Approval>
    {
        public void Configure(EntityTypeBuilder<Approval> builder)
        {
            builder.HasData(
                new Approval
                {
                    Id = 1,



                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Approval
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

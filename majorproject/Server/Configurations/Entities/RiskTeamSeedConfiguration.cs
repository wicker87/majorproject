using majorproject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace majorproject.Server.Configurations.Entities
{
    public class RiskTeamSeedConfiguration : IEntityTypeConfiguration<RiskTeam>
    {
        public void Configure(EntityTypeBuilder<RiskTeam> builder)
        {
            builder.HasData(
                new RiskTeam
                {
                    Id = 1,

                    LeaderId = 1,
                    Member1Id = 3,
                    Member2Id = 4,
                    Member3Id = 5,
                    Member4Id = null,
                    Member5Id = null,

                    FormId = 1,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new RiskTeam
                {
                    Id = 2,

                    LeaderId = 7,
                    Member1Id = 9,
                    Member2Id = 10,
                    Member3Id = 11,
                    Member4Id = 12,
                    Member5Id = 13,

                    FormId = null,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}

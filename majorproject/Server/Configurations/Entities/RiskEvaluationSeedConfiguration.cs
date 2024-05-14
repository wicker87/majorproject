using majorproject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace majorproject.Server.Configurations.Entities
{
    public class RiskEvaluationSeedConfiguration : IEntityTypeConfiguration<RiskEvaluation>
    {
        public void Configure(EntityTypeBuilder<RiskEvaluation> builder)
        {
            builder.HasData(
                new RiskEvaluation
                {
                    Id = 1,



                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new RiskEvaluation
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

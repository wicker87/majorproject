using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using majorproject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace majorproject.Server.Configurations.Entities
{
    public class RiskEvaulationSeedConfiguration: IEntityTypeConfiguration<RiskEvaluation>
{

        public void Configure(EntityTypeBuilder<RiskEvaluation> builder)
        {
            builder.HasData(
               new RiskEvaluation
               {
                   Id = 1,
                   ExistingRiskControls = "Trip and fall due to loose network and power extension cables, damaged floor tiles and wet floor",
                   Severity = 2,
                   Likelihood = 1,
                   RPN = 2,
               }
               );
        }
    }
}

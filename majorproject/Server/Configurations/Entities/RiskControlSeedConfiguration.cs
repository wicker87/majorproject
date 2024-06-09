using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                    AdditionalControls = "All electrical appliances have proper water proofing.",
                    Severity = 2,
                    Likelihood = 1,
                    RPN = 2,
                    ImplementingPerson = "David Young",
                    DueDate = new DateTime(2024, 5, 3),
                    Remarks = null,
                    EvaluationId = 5,
                },
                new RiskControl
                {
                    Id = 2,
                    AdditionalControls = "Conduct monthly checks on the electrical wiring.",
                    Severity = 2,
                    Likelihood = 1,
                    RPN = 2,
                    ImplementingPerson = "David Young",
                    DueDate = new DateTime(2024, 5, 3),
                    Remarks = null,
                    EvaluationId = 6,
                }
                );
        }
    }
}
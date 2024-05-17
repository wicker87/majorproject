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
                    AddControl="",
                    Severity = 0,
                    Likelihood = 0,
                    RPN = 0,
                    ImplementingPerson="",
                    DueDate = DateTime.Now,
                    Remarks="",
                }
                );
        }
    }
}
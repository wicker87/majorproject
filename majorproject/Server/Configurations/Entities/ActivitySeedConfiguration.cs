using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using majorproject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace majorproject.Server.Configurations.Entities
{
    public class ActivitySeedConfiguration: IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.HasData(
                new Activity
                {
                    Id = 1,
                    Name = "Use of MP facility",
                    AssessmentId = 1,
                },
                new Activity
                {
                    Id = 2,
                    Name = "Use of BYOD Notebooks, PCs, Equipment",
                    AssessmentId = 1,
                },
                new Activity
                {
                    Id = 3,
                    Name = "Use of soldering iron in MP labs for hardware related projects",
                    AssessmentId = 1,
                },
                new Activity
                {
                    Id = 4,
                    Name = "Handling of hand tools in MP Labs for hardware related projects",
                    AssessmentId = 1,
                }
                );
        }
    }
}

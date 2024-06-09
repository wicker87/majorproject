using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using majorproject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace majorproject.Server.Configurations.Entities
{
    public class WorkActivitySeedConfiguration: IEntityTypeConfiguration<WorkActivity>
    {
        public void Configure(EntityTypeBuilder<WorkActivity> builder)
        {
            builder.HasData(
                new WorkActivity
                {
                    Id = 1,
                    Name = "Use of MP facility",
                    AssessmentId = 1,
                },
                new WorkActivity
                {
                    Id = 2,
                    Name = "Use of BYOD Notebooks, PCs, Equipment",
                    AssessmentId = 1,
                },
                new WorkActivity
                {
                    Id = 3,
                    Name = "Use of soldering iron in MP labs for hardware related projects",
                    AssessmentId = 1,
                },
                new WorkActivity
                {
                    Id = 4,
                    Name = "Handling of hand tools in MP Labs for hardware related projects",
                    AssessmentId = 1,
                },
                new WorkActivity
                {
                    Id = 5,
                    Name = "Use of facility",
                    AssessmentId = 2,
                },
                new WorkActivity
                {
                    Id = 6,
                    Name = "Use of PCs in Laboratory",
                    AssessmentId = 2,
                },
                new WorkActivity
                {
                    Id = 7,
                    Name = "Maintenance and operation of lab equipment",
                    AssessmentId = 2,
                },
                new WorkActivity
                {
                    Id = 8,
                    Name = "Handling component and lab materials",
                    AssessmentId = 2,
                },
                new WorkActivity
                {
                    Id = 9,
                    Name = "Hand soldering",
                    AssessmentId = 2,
                },
                new WorkActivity
                {
                    Id = 10,
                    Name = "Transportation of lab equipment",
                    AssessmentId = 2,
                }
                );
        }
    }
}

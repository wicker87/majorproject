using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                    Leader = "Eliza Ross",
                    Member1 = "Nina Choo",
                    Member2 = "Maddie Tay",
                    Member3 = "Stanley Hall",
                    Member4 = "Warren Young",
                    Member5 = "Jake Howard"
                },
                new RiskTeam
                {
                    Id = 2,
                    Leader = "Kyle Thomas",
                    Member1 = "Constance Lee",
                    Member2 = "Bobby Brooks",
                    Member3 = null,
                    Member4 = null,
                    Member5 = null
                },
                new RiskTeam
                {
                    Id = 3,
                    Leader = "Tommy Jones",
                    Member1 = "Elena Reed",
                    Member2 = "Ben Danis",
                    Member3 = "Larry Parker",
                    Member4 = "Jimmy Baker",
                    Member5 = null
                }
                );
        }
    }
}
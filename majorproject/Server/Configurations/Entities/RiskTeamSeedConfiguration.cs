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
                    Leader = "Mr Tan Cheng Khoon",
                    MemberOne = "Chai Zhuo Lym Ryan",
                    MemberTwo = "Peh Jun Jie",
                    MemberThree= "Lim Yee Zhe",
                    MemberFour= "",
                    MemberFive = ""
                }
                );
        }
    }
}
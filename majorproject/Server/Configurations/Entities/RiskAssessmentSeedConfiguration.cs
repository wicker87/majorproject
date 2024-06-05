using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using majorproject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace majorproject.Server.Configurations.Entities
{
    public class RiskAssessmentSeedConfiguration : IEntityTypeConfiguration<RiskAssessment>
    {
        public void Configure(EntityTypeBuilder<RiskAssessment> builder)
        {
            builder.HasData(
                new RiskAssessment
                {
                    Id = 1,
                    ApprovedStatus = true,
                    Name = "CEN MP Risk Assessment",
                    Department="Temasek Poly (ENG)",
                    Process= "CEN MP - April 2024",
                    Location= "EN10-2-15",
                    AssessmentDate = new DateTime(2024, 4, 26),
                    LastReviewDate= new DateTime(2024, 4, 26),
                    NextReviewDate = new DateTime(2027, 4, 26),
                    RiskTeamId= 2,
                    Approver = "John Smith",
                    ApprovalDate= new DateTime(2024, 4, 28),
                }
                );
        }
    }
}
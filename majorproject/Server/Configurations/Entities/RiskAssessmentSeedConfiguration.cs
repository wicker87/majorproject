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
                    TeamId= 2,
                    Approver = "John Smith",
                    ApprovalDate= new DateTime(2024, 4, 28),
                },
                new RiskAssessment
                {
                    Id = 2,
                    ApprovedStatus = true,
                    Name = "TP-ENG Laboratories Risk Assessment",
                    Department = "School of Engineering",
                    Process = "ELN/CEN/ABS/IFM/AEL/AEG//BME/IIT/MTN",
                    Location = "EN15-06-051, EN15-06-052, EN15-06-053, EN15-06-055, EN15-06-057, EN15-06-058, EN16-03-35, EN16-03-42",
                    AssessmentDate = new DateTime(2018, 1, 26),
                    LastReviewDate = new DateTime(2023, 12, 1),
                    NextReviewDate = new DateTime(2026, 11, 30),
                    TeamId = 4,
                    Approver = "Benjamin Scott",
                    ApprovalDate = new DateTime(2023, 12, 6),
                }
                );
        }
    }
}
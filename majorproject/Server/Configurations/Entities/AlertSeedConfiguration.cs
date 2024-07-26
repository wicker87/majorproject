using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using majorproject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace majorproject.Server.Configurations.Entities
{
    public class AlertSeedConfiguration : IEntityTypeConfiguration<Alert>
    {
        public void Configure(EntityTypeBuilder<Alert> builder)
        {
            builder.HasData(
                new Alert
                {
                    Id = 1,
                    Message = "📄A new risk assessment, CEN MP Risk Assessment, has been created.",
                    DateTime = new DateTime(2024, 4, 24, 10, 2, 30),
                    AssessmentId = 1,
                },
                new Alert
                {
                    Id = 2,
                    Message = "✅John Smith (Manager) has approved the risk assessment, CEN MP Risk Assessment.",
                    DateTime = new DateTime(2024, 4, 26, 17, 30, 28),
                    AssessmentId = 1,
                },
                new Alert
                {
                    Id = 3,
                    Message = "📄A new risk assessment, TP-ENG Laboratories Risk Assessment, has been created.",
                    DateTime = new DateTime(2024, 5, 10, 14, 12, 41),
                    AssessmentId = 2,
                },
                new Alert
                {
                    Id = 4,
                    Message = "❎Benjamin Scott (Manager) has unapproved the risk assessment, TP-ENG Laboratories Risk Assessment.",
                    DateTime = new DateTime(2024, 5, 13, 15, 20, 5),
                    AssessmentId = 2,
                },
                new Alert
                {
                    Id = 5,
                    Message = "✅Benjamin Scott (Manager) has approved the risk assessment, TP-ENG Laboratories Risk Assessment.",
                    DateTime = new DateTime(2024, 5, 15, 18, 5, 21),
                    AssessmentId = 2,
                }
                );
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using majorproject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace majorproject.Server.Configurations.Entities
{
    public class RAFSeedConfiguration : IEntityTypeConfiguration<RAF>
    {
        public void Configure(EntityTypeBuilder<RAF> builder)
        {
            builder.HasData(
                new RAF
                {
                    Id = 1,
                    Department="TP Staff",
                    Process= "CEN MP - April 2024",
                    Location= "EN10-2-15",
                    AssessmentDate = DateTime.Now,
                    LastReviewDate= DateTime.Now,
                    NextReviewDate= DateTime.Now,

                }
                );
        }
    }
}
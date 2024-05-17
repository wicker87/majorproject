using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using majorproject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace majorproject.Server.Configurations.Entities
{
    public class HazardSeedConfiguration: IEntityTypeConfiguration<Hazard>
    {
        public void Configure(EntityTypeBuilder<Hazard> builder)
        {
            builder.HasData(
                new Hazard
                {
                    Id = 1,
                    HazardName = "Trip and fall due to loose network and power extension cables, damaged floor tiles and wet floor",
                    PossibleInjury = "Bodily Injuries"
                }
                );
        }
    }
}

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
                    Name = "Trip and fall due to loose network and power extension cables, damaged floor tiles and wet floor",
                    PossibleInjury = "Bodily Injuries",
                    ActivityId = 1
                },
                new Hazard
                {
                    Id = 2,
                    Name = "Falling ceiling board and and lights holding",
                    PossibleInjury = "Head & Bodily Injuries",
                    ActivityId = 1
                },
                new Hazard
                {
                    Id = 3,
                    Name = "Contact with electrical parts and faulty cables with live exposed wires",
                    PossibleInjury = "Electrocution",
                    ActivityId = 2
                },
                new Hazard
                {
                    Id = 4,
                    Name = "Contact with hot surface / soldering iron",
                    PossibleInjury = "Burns to exposed skin",
                    ActivityId = 3
                },
                new Hazard
                {
                    Id = 5,
                    Name = "Piercing by soldering iron tip",
                    PossibleInjury = "Minor Cuts",
                    ActivityId = 3
                },
                new Hazard
                {
                    Id = 6,
                    Name = "Inhaling fumes from soldering",
                    PossibleInjury = "Eye, nose and throat irritation",
                    ActivityId = 3
                },
                new Hazard
                {
                    Id = 7,
                    Name = "Contact with sharp edges and pointed tips",
                    PossibleInjury = "Injury to exposed skin/hand",
                    ActivityId = 4
                },
                new Hazard
                {
                    Id = 8,
                    Name = "Trip and fall due to hand tools/equipment on the floor",
                    PossibleInjury = "Head & Bodily Injuries",
                    ActivityId = 4
                }
                );
        }
    }
}

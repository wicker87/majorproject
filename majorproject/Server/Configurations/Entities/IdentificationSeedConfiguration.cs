﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using majorproject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace majorproject.Server.Configurations.Entities
{
    public class IdentificationSeedConfiguration: IEntityTypeConfiguration<Identification>
    {
        public void Configure(EntityTypeBuilder<Identification> builder)
        {
            builder.HasData(
                new Identification
                {
                    Id = 1,
                    Name = "Trip and fall due to loose network and power extension cables, damaged floor tiles and wet floor",
                    PossibleInjury = "Bodily Injuries",
                    ActivityId = 1
                },
                new Identification
                {
                    Id = 2,
                    Name = "Falling ceiling board and and lights holding",
                    PossibleInjury = "Head & Bodily Injuries",
                    ActivityId = 1
                },
                new Identification
                {
                    Id = 3,
                    Name = "Contact with electrical parts and faulty cables with live exposed wires",
                    PossibleInjury = "Electrocution",
                    ActivityId = 2
                },
                new Identification
                {
                    Id = 4,
                    Name = "Contact with hot surface / soldering iron",
                    PossibleInjury = "Burns to exposed skin",
                    ActivityId = 3
                },
                new Identification
                {
                    Id = 5,
                    Name = "Piercing by soldering iron tip",
                    PossibleInjury = "Minor Cuts",
                    ActivityId = 3
                },
                new Identification
                {
                    Id = 6,
                    Name = "Inhaling fumes from soldering",
                    PossibleInjury = "Eye, nose and throat irritation",
                    ActivityId = 3
                },
                new Identification
                {
                    Id = 7,
                    Name = "Contact with sharp edges and pointed tips",
                    PossibleInjury = "Injury to exposed skin/hand",
                    ActivityId = 4
                },
                new Identification
                {
                    Id = 8,
                    Name = "Trip and fall due to hand tools/equipment on the floor",
                    PossibleInjury = "Head & Bodily Injuries",
                    ActivityId = 4
                },
                new Identification
                {
                    Id = 9,
                    Name = "Trip and fall due to loose network and power extension cables, damaged floor tiles and wet floor",
                    PossibleInjury = "Bodily Injuries",
                    ActivityId = 5
                },
                new Identification
                {
                    Id = 10,
                    Name = "Falling ceiling board and lights holding",
                    PossibleInjury = "Head & Bodily Injuries",
                    ActivityId = 5
                },
                new Identification
                {
                    Id = 11,
                    Name = "Contact with electrical parts and faulty cables with live exposed wires",
                    PossibleInjury = "Electrocution",
                    ActivityId = 6
                },
                new Identification
                {
                    Id = 12,
                    Name = "Heavy equipment falling to ground",
                    PossibleInjury = "Injury & bruises",
                    ActivityId = 7
                },
                new Identification
                {
                    Id = 13,
                    Name = "Awkward working posture",
                    PossibleInjury = "Back injury",
                    ActivityId = 7
                },
                new Identification
                {
                    Id = 14,
                    Name = "Electrical",
                    PossibleInjury = "Electrical shock, burns, electrocution",
                    ActivityId = 7
                },
                new Identification
                {
                    Id = 15,
                    Name = "Contact with sharp edges",
                    PossibleInjury = "Minor cuts",
                    ActivityId = 8
                },
                new Identification
                {
                    Id = 16,
                    Name = "Contact with hot surface",
                    PossibleInjury = "Skin burns",
                    ActivityId = 9
                },
                new Identification
                {
                    Id = 17,
                    Name = "Pierced by soldering iron tip",
                    PossibleInjury = "Minor cuts",
                    ActivityId = 9
                },
                new Identification
                {
                    Id = 18,
                    Name = "Inhalation of soldering fume",
                    PossibleInjury = "Respiratory Irritation from soldering fume",
                    ActivityId = 9
                },
                new Identification
                {
                    Id = 19,
                    Name = "Ingesting lead dust on solder",
                    PossibleInjury = "Ill-heath effect from Lead poisoning",
                    ActivityId = 9
                },
                new Identification
                {
                    Id = 20,
                    Name = "Heavy equipment fall to ground Physical-forceful exertions",
                    PossibleInjury = "Leg injury, Back and arm injuries",
                    ActivityId = 10
                }
                );
        }
    }
}

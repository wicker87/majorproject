using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using majorproject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace majorproject.Server.Configurations.Entities
{
    public class RiskEvaulationSeedConfiguration: IEntityTypeConfiguration<RiskEvaluation>
{

        public void Configure(EntityTypeBuilder<RiskEvaluation> builder)
        {
            builder.HasData(
               new RiskEvaluation
               {
                   Id = 1,
                   ExistingRiskControls = "Loose network / power extension cables on the floor are taped",
                   Severity = 2,
                   Likelihood = 1,
                   RPN = 2,
                   HazardId = 1
               },
               new RiskEvaluation
               {
                   Id = 2,
                   ExistingRiskControls = "Visual check of the lab for any damages floor tiles and report to EFM " +
                   "@ 67805955 for repair and temporary taped up the damaged floor tiles",
                   Severity = 2,
                   Likelihood = 2,
                   RPN = 4,
                   HazardId = 1
               },
               new RiskEvaluation
               {
                   Id = 3,
                   ExistingRiskControls = "Get cleaner to mop the floor, report to EFM @ 67805955",
                   Severity = 3,
                   Likelihood = 1,
                   RPN = 3,
                   HazardId = 1
               },
               new RiskEvaluation
               {
                   Id = 4,
                   ExistingRiskControls = "Visual check of the lab for any damages and report to EFM @ 67805955 for repair",
                   Severity = 3,
                   Likelihood = 1,
                   RPN = 3,
                   HazardId = 2
               },
               new RiskEvaluation
               {
                   Id = 5,
                   ExistingRiskControls = "Do not touch electricial appliances with wet hands",
                   Severity = 5,
                   Likelihood = 1,
                   RPN = 5,
                   HazardId = 3
               },
               new RiskEvaluation
               {
                   Id = 6,
                   ExistingRiskControls = "Ensure there is no frayed or exposed wiring, report EFM @ 67805955 or Staff-in-charge immedialtely",
                   Severity = 5,
                   Likelihood = 1,
                   RPN = 5,
                   HazardId = 3
               },
               new RiskEvaluation
               {
                   Id = 7,
                   ExistingRiskControls = "Switch off the power when plugging/unplugging the power plug from the wall socket",
                   Severity = 5,
                   Likelihood = 1,
                   RPN = 5,
                   HazardId = 3
               },
               new RiskEvaluation
               {
                   Id = 8,
                   ExistingRiskControls = "Conduct briefing on proper use of soldering iron prior to first-time use.",
                   Severity = 2,
                   Likelihood = 2,
                   RPN = 4,
                   HazardId = 4
               },
               new RiskEvaluation
               {
                   Id = 9,
                   ExistingRiskControls = "Remain focused on the soldering task and not engage in conversation.",
                   Severity = 2,
                   Likelihood = 2,
                   RPN = 4,
                   HazardId = 4
               },
               new RiskEvaluation
               {
                   Id = 10,
                   ExistingRiskControls = "Soldering iron must be returned to is holder and be placed in its holder when not in use.",
                   Severity = 2,
                   Likelihood = 2,
                   RPN = 4,
                   HazardId = 4
               },
               new RiskEvaluation
               {
                   Id = 11,
                   ExistingRiskControls = "Return soldering iron to stand after use",
                   Severity = 2,
                   Likelihood = 1,
                   RPN = 2,
                   HazardId = 5
               },
               new RiskEvaluation
               {
                   Id = 12,
                   ExistingRiskControls = "Avoid the “head-bentover-project” soldering posture.",
                   Severity = 2,
                   Likelihood = 3,
                   RPN = 6,
                   HazardId = 6
               },
               new RiskEvaluation
               {
                   Id = 13,
                   ExistingRiskControls = "Ensure adequate ventilation in the lab when soldering.",
                   Severity = 2,
                   Likelihood = 3,
                   RPN = 6,
                   HazardId = 6
               },
               new RiskEvaluation
               {
                   Id = 14,
                   ExistingRiskControls = "Using of solder fume extractor.",
                   Severity = 2,
                   Likelihood = 3,
                   RPN = 6,
                   HazardId = 6
               },
               new RiskEvaluation
               {
                   Id = 15,
                   ExistingRiskControls = "Adopt safe working practices when handling sharp tools.",
                   Severity = 2,
                   Likelihood = 2,
                   RPN = 4,
                   HazardId = 7
               },
               new RiskEvaluation
               {
                   Id = 16,
                   ExistingRiskControls = "Ensure all unused equipment/tools are kept properly when not in use or when away.",
                   Severity = 3,
                   Likelihood = 1,
                   RPN = 3,
                   HazardId = 8
               }
            );
        }
    }
}

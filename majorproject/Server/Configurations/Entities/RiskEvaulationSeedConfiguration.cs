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
                   ExistingRiskControls = "Do not touch electrical appliances with wet hands",
                   Severity = 5,
                   Likelihood = 1,
                   RPN = 5,
                   HazardId = 3
               },
               new RiskEvaluation
               {
                   Id = 6,
                   ExistingRiskControls = "Ensure there is no frayed or exposed wiring, report EFM @ 67805955 or Staff-in-charge immediately",
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
                   ExistingRiskControls = "Avoid the “head-bent-over-project” soldering posture.",
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
               },
               new RiskEvaluation
               {
                   Id = 17,
                   ExistingRiskControls = "Loose network / power extension cables on the floor are taped.",
                   Severity = 3,
                   Likelihood = 1,
                   RPN = 3,
                   HazardId = 9
               },
               new RiskEvaluation
               {
                   Id = 18,
                   ExistingRiskControls = "Visual check of the lab for any damages floor tiles and report to EFM @67805955 " +
                   "for repair and temporary taped up the damaged floor tiles.",
                   Severity = 3,
                   Likelihood = 1,
                   RPN = 3,
                   HazardId = 9
               },
               new RiskEvaluation
               {
                   Id = 19,
                   ExistingRiskControls = "Get cleaner to mop the floor, report to EFM @ 67805955.",
                   Severity = 3,
                   Likelihood = 1,
                   RPN = 3,
                   HazardId = 9
               },
               new RiskEvaluation
               {
                   Id = 20,
                   ExistingRiskControls = "Visual check of the lab for any damages and report to EFM @ 67805955 for repair.",
                   Severity = 3,
                   Likelihood = 1,
                   RPN = 3,
                   HazardId = 10
               },
               new RiskEvaluation
               {
                   Id = 21,
                   ExistingRiskControls = "Alternative location for classes when the needs arise due to severity of situation.",
                   Severity = 3,
                   Likelihood = 1,
                   RPN = 3,
                   HazardId = 10
               },
               new RiskEvaluation
               {
                   Id = 22,
                   ExistingRiskControls = "Do not touch electrical appliances with wet hands.",
                   Severity = 4,
                   Likelihood = 1,
                   RPN = 4,
                   HazardId = 11
               },
               new RiskEvaluation
               {
                   Id = 23,
                   ExistingRiskControls = "Ensure there is no frayed or exposed wiring, report EFM @ 67805955 or Staff-in-charge immediately.",
                   Severity = 4,
                   Likelihood = 1,
                   RPN = 4,
                   HazardId = 11
               },
               new RiskEvaluation
               {
                   Id = 24,
                   ExistingRiskControls = "Switch off the power when plugging/unplugging the power plug from the wall socket.",
                   Severity = 4,
                   Likelihood = 1,
                   RPN = 4,
                   HazardId = 11
               },
               new RiskEvaluation
               {
                   Id = 25,
                   ExistingRiskControls = "Wear Safety Shoe.",
                   Severity = 3,
                   Likelihood = 2,
                   RPN = 6,
                   HazardId = 12
               },
               new RiskEvaluation
               {
                   Id = 26,
                   ExistingRiskControls = "Use of trolley for carrying heavy items.",
                   Severity = 3,
                   Likelihood = 2,
                   RPN = 6,
                   HazardId = 12
               },
               new RiskEvaluation
               {
                   Id = 27,
                   ExistingRiskControls = "Seek additional help if unable to handle the equipment.",
                   Severity = 3,
                   Likelihood = 2,
                   RPN = 6,
                   HazardId = 12
               },
               new RiskEvaluation
               {
                   Id = 28,
                   ExistingRiskControls = "Always use leg muscles and keep back straight while lifting, adopt the correct lifting posture.",
                   Severity = 3,
                   Likelihood = 2,
                   RPN = 6,
                   HazardId = 13
               },
               new RiskEvaluation
               {
                   Id = 29,
                   ExistingRiskControls = "Electrical ELCB are installed in the laboratory",
                   Severity = 5,
                   Likelihood = 1,
                   RPN = 5,
                   HazardId = 14
               },
               new RiskEvaluation
               {
                   Id = 30,
                   ExistingRiskControls = "Power off and unplug the power from the equipment when not in use.",
                   Severity = 5,
                   Likelihood = 1,
                   RPN = 5,
                   HazardId = 14
               },
               new RiskEvaluation
               {
                   Id = 31,
                   ExistingRiskControls = "Wear proper safety footwear.",
                   Severity = 5,
                   Likelihood = 1,
                   RPN = 5,
                   HazardId = 14
               },
               new RiskEvaluation
               {
                   Id = 32,
                   ExistingRiskControls = "Proper handling (use of electronic tools)",
                   Severity = 3,
                   Likelihood = 2,
                   RPN = 6,
                   HazardId = 15
               },
               new RiskEvaluation
               {
                   Id = 33,
                   ExistingRiskControls = "Switch off soldering iron after used",
                   Severity = 3,
                   Likelihood = 2,
                   RPN = 6,
                   HazardId = 16
               },
               new RiskEvaluation
               {
                   Id = 34,
                   ExistingRiskControls = "Return iron to stand after used",
                   Severity = 3,
                   Likelihood = 2,
                   RPN = 6,
                   HazardId = 16
               },
               new RiskEvaluation
               {
                   Id = 35,
                   ExistingRiskControls = "Return iron to stand after used.",
                   Severity = 3,
                   Likelihood = 1,
                   RPN = 3,
                   HazardId = 17
               },
               new RiskEvaluation
               {
                   Id = 36,
                   ExistingRiskControls = "Laboratory to be well ventilated during soldering.",
                   Severity = 3,
                   Likelihood = 2,
                   RPN = 6,
                   HazardId = 18
               },
               new RiskEvaluation
               {
                   Id = 37,
                   ExistingRiskControls = "Wash hands with soap immediately after soldering before going for meals.",
                   Severity = 4,
                   Likelihood = 1,
                   RPN = 4,
                   HazardId = 19
               },
               new RiskEvaluation
               {
                   Id = 38,
                   ExistingRiskControls = "Safety briefing to staff on soldering safety if lead based solders are used.",
                   Severity = 4,
                   Likelihood = 1,
                   RPN = 4,
                   HazardId = 19
               },
               new RiskEvaluation
               {
                   Id = 39,
                   ExistingRiskControls = "Consider using lead-free solder.",
                   Severity = 4,
                   Likelihood = 1,
                   RPN = 4,
                   HazardId = 19
               },
               new RiskEvaluation
               {
                   Id = 40,
                   ExistingRiskControls = "Practice good housekeeping to remove soldering remnants on benches by sweeping and cleaning.",
                   Severity = 4,
                   Likelihood = 1,
                   RPN = 4,
                   HazardId = 19
               },
               new RiskEvaluation
               {
                   Id = 41,
                   ExistingRiskControls = "Wear safety shoes",
                   Severity = 3,
                   Likelihood = 2,
                   RPN = 6,
                   HazardId = 20
               },
               new RiskEvaluation
               {
                   Id = 42,
                   ExistingRiskControls = "Use trolley for transportation of equipment",
                   Severity = 3,
                   Likelihood = 2,
                   RPN = 6,
                   HazardId = 20
               },
               new RiskEvaluation
               {
                   Id = 43,
                   ExistingRiskControls = "Limit weight stacked on trolley, trained on manual handling techniques",
                   Severity = 3,
                   Likelihood = 2,
                   RPN = 6,
                   HazardId = 20
               }
            );
        }
    }
}

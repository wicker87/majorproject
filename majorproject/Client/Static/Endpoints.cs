using majorproject.Shared.Domain;
using System.Collections.Generic;

namespace majorproject.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string WorkActivitiesEndpoint = $"{Prefix}/workactivities";
        public static readonly string IdentificationsEndpoint = $"{Prefix}/identifications";
        public static readonly string RiskTeamsEndpoint = $"{Prefix}/riskteams";
        public static readonly string RiskAssessmentsEndpoint = $"{Prefix}/riskassessments";
        public static readonly string HazardsEndpoint = $"{Prefix}/hazards";
        public static readonly string RiskEvaluationsEndpoint = $"{Prefix}/riskevaluations";
        public static readonly string RiskControlsEndpoint = $"{Prefix}/riskcontrols";
        public static readonly string AlertsEndpoint = $"{Prefix}/alerts";
    }
}

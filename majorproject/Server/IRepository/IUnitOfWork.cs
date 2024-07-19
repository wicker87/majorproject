using majorproject.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace majorproject.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);       
        IGenericRepository<RiskAssessment> RiskAssessments { get; }
        IGenericRepository<WorkActivity> WorkActivities { get; }
        IGenericRepository<Identification> Identifications { get; }
        IGenericRepository<RiskEvaluation> RiskEvaluations { get; }
        IGenericRepository<RiskControl> RiskControls { get; }      
        IGenericRepository<RiskTeam> RiskTeams { get; }
        IGenericRepository<Alert> Alerts { get; }
    }
}
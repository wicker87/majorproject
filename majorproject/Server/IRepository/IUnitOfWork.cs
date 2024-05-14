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
        IGenericRepository<Activity> Activities { get; }
        IGenericRepository<Approval> Approvals { get; }
        IGenericRepository<Employee> Employees { get; }
        IGenericRepository<Hazard> Hazards { get; }
        IGenericRepository<RAF> RAFs { get; }
        IGenericRepository<RiskControl> RiskControls { get; }
        IGenericRepository<RiskEvaluation> RiskEvaluations { get; }
        IGenericRepository<RiskTeam> RiskTeams { get; }
    }
}
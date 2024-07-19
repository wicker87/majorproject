using majorproject.Server.Data;
using majorproject.Server.IRepository;
using majorproject.Server.Models;
using majorproject.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace majorproject.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<WorkActivity> _workActivities;
        private IGenericRepository<Identification> _identifications;
        private IGenericRepository<RiskAssessment> _riskAssessments;
        private IGenericRepository<RiskControl> _riskControls;
        private IGenericRepository<RiskEvaluation> _riskEvaluations;
        private IGenericRepository<RiskTeam> _riskTeams;
        private IGenericRepository<Alert> _alerts;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<WorkActivity> WorkActivities
            => _workActivities ??= new GenericRepository<WorkActivity>(_context);
        public IGenericRepository<Identification> Identifications
            => _identifications ??= new GenericRepository<Identification>(_context);
        public IGenericRepository<RiskAssessment> RiskAssessments
            => _riskAssessments ??= new GenericRepository<RiskAssessment>(_context);
        public IGenericRepository<RiskControl> RiskControls
            => _riskControls ??= new GenericRepository<RiskControl>(_context);
        public IGenericRepository<RiskEvaluation> RiskEvaluations
            => _riskEvaluations ??= new GenericRepository<RiskEvaluation>(_context);
        public IGenericRepository<RiskTeam> RiskTeams
            => _riskTeams ??= new GenericRepository<RiskTeam>(_context);
        public IGenericRepository<Alert> Alerts
            => _alerts ??= new GenericRepository<Alert>(_context);
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "system";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);          

            await _context.SaveChangesAsync();
        }
    }
}
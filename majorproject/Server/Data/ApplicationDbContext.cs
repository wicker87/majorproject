﻿using Duende.IdentityServer.EntityFramework.Options;
using majorproject.Shared.Domain;
using majorproject.Server.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Cryptography.X509Certificates;
using majorproject.Server.Configurations.Entities;

namespace majorproject.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<RiskAssessment> RiskAssessments { get; set; }
        public DbSet<WorkActivity> WorkActivities { get; set; }
        public DbSet<Identification> Identifications { get; set; }
        public DbSet<RiskEvaluation> RiskEvaluations { get; set; }
        public DbSet<RiskControl> RiskControls { get; set;}       
        public DbSet<RiskTeam> RiskTeams { get; set; }
        public DbSet<ImageSource> ImageSources { get; set; }
        public DbSet<Alert> Alerts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new WorkActivitySeedConfiguration());

            builder.ApplyConfiguration(new IdentificationSeedConfiguration());

            builder.ApplyConfiguration(new RiskControlSeedConfiguration());

            builder.ApplyConfiguration(new RiskEvaulationSeedConfiguration());

            builder.ApplyConfiguration(new RiskAssessmentSeedConfiguration());

            builder.ApplyConfiguration(new RiskTeamSeedConfiguration());

            builder.ApplyConfiguration(new AlertSeedConfiguration());

            // Identity seed
            builder.ApplyConfiguration(new RoleSeedConfiguration());

            builder.ApplyConfiguration(new UserSeedConfiguration());

            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }
    }
}

using Jupiter.Business.Core.Implementation;
using Jupiter.Business.Core.Interface;
using JupiterWeb.Application.Contracts.Persistence;
using JupiterWeb.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace JupiterWeb.Persistence
{
    public static class PersistenceServiceRegistration
    {

        [ExcludeFromCodeCoverage]
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            var dbProvider = configuration.GetValue<string>("dbProvider");

            switch (dbProvider)
            {
                case "MSSQL":
                    services.AddDbContext<ValuationDbContext>(options =>
                        options.UseSqlServer(configuration.GetConnectionString("MedullaEmergencyDBConn")));
                    break;
                default:
                    break;
            }

           
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IBranchRepository, BranchRepository>();
            //services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IMasterCityRepository, MasterCityRepository>();
            services.AddTransient<IMasterUserService, MasterUserService>();
            services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
            services.AddTransient<IAuditLogService, AuditLogService>();
            services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
            services.AddTransient<IMasterNotificationService, MasterNotificationService>();
            services.AddTransient<IDashBoardService, DashBoardService>();
            services.AddSingleton<IMemoryCache, MemoryCache>();
            
            return services;
        }
    }
}

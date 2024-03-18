using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Jupiter.Business.Core.Interface;
using Jupiter.Business.Core.ModelMapper;
using Jupiter.Business.Core.Implementation;
using Jupiter.Data.DataAccess.Core.UnitOfWork;
using Jupiter.Data.DataAccess.Core.Repositories;
using Jupiter.Data.DataAccess.DataContext;

namespace Jupiter.Business.Core.Resolver
{
    public static class DependencyResolver
    {
        public static IServiceCollection ContainerResolver(this IServiceCollection services)
        {
            
            services.AddScoped<DbContext, MedullaEmergencyDBContext>();
            services.AddScoped<IMapperFactory, MapperFactory>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
                   
           
            services.AddTransient<IHelper, Helper>();

            services.AddTransient<IExceptionService, ExceptionService>();
           

            return services;
        }

    }
}

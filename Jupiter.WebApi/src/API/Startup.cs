using Jupiter.Business.Core.Implementation;
using Jupiter.Business.Core.Interface;
using Jupiter.Utility.Utility;
using Jupiter.WebApi.Filters;

namespace Jupiter.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            DatabaseConnection.ConnString = Configuration.GetSection("ConnectionStrings:MedullaEmergencyDBConn").Value;

            services.AddScoped<IMasterUserService, MasterUserService>();

            services.AddControllers(options =>
            {
                options.Filters.Add(typeof(ExceptionFilter));
            }).AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.WriteIndented = true;
            }).AddNewtonsoftJson();

            //services.AddResource();//me
        }
    }
}

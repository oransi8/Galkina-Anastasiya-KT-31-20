using GalkinaAnastasiyaKT_31_20.Models;
using GalkinaAnastasiyaKT_31_20.Interfaces.StudentsInterfaces;

namespace GalkinaAnastasiyaKT_31_20.ServiceExtensions
{
  public static class ServiceExtensions
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            return services;
        }
    }
}

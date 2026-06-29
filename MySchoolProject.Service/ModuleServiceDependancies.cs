using Microsoft.Extensions.DependencyInjection;
using MySchoolProject.Service.Abstracts;
using MySchoolProject.Service.AuthService.Abstract;
using MySchoolProject.Service.AuthService.Implementaions;
using MySchoolProject.Service.Implementations;

namespace MySchoolProject.Service
{
    public static class ModuleServiceDependancies
    {
        public static IServiceCollection AddServiceDependancies(this IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();
            services.AddTransient<IDepartmentService, DepartmentService>();
            services.AddTransient<IAuthenticationService, AuthenticationService>();
            services.AddTransient<IAuthorizationService, AuthorizationService>();
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IApplicationUserService, ApplicationUserService>();
            services.AddTransient<ICurrentUserService, CurrentUserService>();

            return services;
        }
    }
}

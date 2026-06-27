using Microsoft.Extensions.DependencyInjection;
using MySchoolProject.Infrustructure.InfrustructureBases;
using MySchoolProject.Infrustructure.IRepositories;
using MySchoolProject.Infrustructure.Repositories;

namespace MySchoolProject.Infrustructure
{
    public static class ModuleInfrustructureDependancies
    {
        public static IServiceCollection AddInfrustructureDependancies(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IDepartmentRepository, DepartmentRepository>();
            services.AddTransient<IInstructorsRepository, InstructorsRepository>();
            services.AddTransient<ISubjectRepository, SubjectRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IRefreshTokenRepository, RefreshTokenRepository>();
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            return services;
        }
    }
}

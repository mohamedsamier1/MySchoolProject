using Microsoft.Extensions.DependencyInjection;
using MySchoolProject.Date.Entities.Views;
using MySchoolProject.Infrustructure.InfrustructureBases;
using MySchoolProject.Infrustructure.IRepositories;
using MySchoolProject.Infrustructure.IRepositories.Procedures;
using MySchoolProject.Infrustructure.IRepositories.Views;
using MySchoolProject.Infrustructure.Repositories;
using MySchoolProject.Infrustructure.Repositories.Procedures;
using MySchoolProject.Infrustructure.Repositories.Views;

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

            //views
            services.AddTransient<IViewRepository<ViewDepartment>, ViewDepartmentRepository>();
            //procedure
            services.AddTransient<IDepartmentStudentCountProcRepository, DepartmentStudentCountProcRepository>();

            return services;
        }
    }
}

using MySchoolProject.Infrustructure.InfrustructureBases;

namespace MySchoolProject.Infrustructure.IRepositories.Views
{
    public interface IViewRepository<T> : IGenericRepositoryAsync<T> where T : class
    {

    }
}

using MySchoolProject.Date.Entities;
using MySchoolProject.Infrustructure.InfrustructureBases;

namespace MySchoolProject.Infrustructure.IRepositories
{
    public interface IStudentRepository : IGenericRepositoryAsync<Student>
    {
        public Task<List<Student>> GeStudentsListAsunc();
    }
}

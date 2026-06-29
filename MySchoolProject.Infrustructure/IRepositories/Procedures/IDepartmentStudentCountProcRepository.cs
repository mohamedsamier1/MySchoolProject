using MySchoolProject.Date.Entities.Procedures;

namespace MySchoolProject.Infrustructure.IRepositories.Procedures
{
    public interface IDepartmentStudentCountProcRepository
    {
        public Task<IReadOnlyList<DepartmentStudentCountProc>> GetDepartmentStudentCountProcs(DepartmentStudentCountProcParameters parameters);
    }
}

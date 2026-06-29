
using MySchoolProject.Date.Entities;
using MySchoolProject.Date.Entities.Procedures;
using MySchoolProject.Date.Entities.Views;

namespace MySchoolProject.Service.Abstracts
{
    public interface IDepartmentService
    {
        public Task<Department> GetDepartmentById(int id);
        public Task<bool> IsDepartmentIdExist(int id);
        public Task<List<ViewDepartment>> GetViewDepartment();
        public Task<IReadOnlyList<DepartmentStudentCountProc>> GetDepartmentStudentCountProcs(DepartmentStudentCountProcParameters parameters);


    }
}

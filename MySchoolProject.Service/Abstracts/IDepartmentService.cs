
using MySchoolProject.Date.Entities;

namespace MySchoolProject.Service.Abstracts
{
    public interface IDepartmentService
    {
        public Task<Department> GetDepartmentById(int id);
        public Task<bool> IsDepartmentIdExist(int id);

    }
}

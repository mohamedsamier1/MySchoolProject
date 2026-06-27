using Microsoft.EntityFrameworkCore;

using MySchoolProject.Date.Entities;
using MySchoolProject.Infrustructure.IRepositories;
using MySchoolProject.Service.Abstracts;

namespace MySchoolProject.Service.Implementations
{
    public class DepartmentService : IDepartmentService
    {
        #region Filds
        private readonly IDepartmentRepository _departmentRepository;
        #endregion
        #region Conatructors
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        #endregion
        #region Handel
        public async Task<Department> GetDepartmentById(int id)
        {
            var department = await _departmentRepository.GetTableNoTracking()
                                                 .Where(x => x.DId.Equals(id))
                                                 .Include(x => x.InstructorMangers)
                                                 .Include(x => x.Instructors)
                                                 .Include(x => x.DepartmentSubjects).ThenInclude(x => x.Subject)
                                                 .FirstOrDefaultAsync();
            return department;
        }

        public async Task<bool> IsDepartmentIdExist(int id)
        {
            return await _departmentRepository.GetTableNoTracking().AnyAsync(x => x.DId.Equals(id));
        }
        #endregion

    }
}

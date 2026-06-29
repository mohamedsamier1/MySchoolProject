using Microsoft.EntityFrameworkCore;

using MySchoolProject.Date.Entities;
using MySchoolProject.Date.Entities.Procedures;
using MySchoolProject.Date.Entities.Views;
using MySchoolProject.Infrustructure.IRepositories;
using MySchoolProject.Infrustructure.IRepositories.Procedures;
using MySchoolProject.Infrustructure.IRepositories.Views;
using MySchoolProject.Service.Abstracts;

namespace MySchoolProject.Service.Implementations
{
    public class DepartmentService : IDepartmentService
    {
        #region Filds
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IViewRepository<ViewDepartment> _viewDepartmentRepository;
        private readonly IDepartmentStudentCountProcRepository _departmentStudentCountProcRepository;
        #endregion
        #region Conatructors
        public DepartmentService(IDepartmentRepository departmentRepository, IViewRepository<ViewDepartment> viewDepartmentRepository, IDepartmentStudentCountProcRepository departmentStudentCountProcRepository)
        {
            _departmentRepository = departmentRepository;
            _viewDepartmentRepository = viewDepartmentRepository;
            _departmentStudentCountProcRepository = departmentStudentCountProcRepository;
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

        public async Task<List<ViewDepartment>> GetViewDepartment()
        {
            var viewDepartment = await _viewDepartmentRepository.GetTableNoTracking().ToListAsync();
            return viewDepartment;
        }

        public async Task<IReadOnlyList<DepartmentStudentCountProc>> GetDepartmentStudentCountProcs(DepartmentStudentCountProcParameters parameters)
        {
            return await _departmentStudentCountProcRepository.GetDepartmentStudentCountProcs(parameters);
        }
        #endregion

    }
}

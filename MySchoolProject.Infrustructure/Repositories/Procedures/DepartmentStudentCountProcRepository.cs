using MySchoolProject.Date.Entities.Procedures;
using MySchoolProject.Infrustructure.Data;
using MySchoolProject.Infrustructure.IRepositories.Procedures;
using StoredProcedureEFCore;

namespace MySchoolProject.Infrustructure.Repositories.Procedures
{
    public class DepartmentStudentCountProcRepository : IDepartmentStudentCountProcRepository
    {
        #region feild
        private readonly ApplicationDbContext _context;
        #endregion
        #region Const
        public DepartmentStudentCountProcRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        #endregion
        #region handel func
        public async Task<IReadOnlyList<DepartmentStudentCountProc>> GetDepartmentStudentCountProcs(DepartmentStudentCountProcParameters parameters)
        {
            var rows = new List<DepartmentStudentCountProc>();
            await _context.LoadStoredProc(nameof(DepartmentStudentCountProc))
                .AddParam(nameof(DepartmentStudentCountProcParameters.DId), parameters.DId)
                .ExecAsync(async r => rows = await r.ToListAsync<DepartmentStudentCountProc>());
            return rows;
        }
        #endregion

    }
}

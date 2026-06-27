using Microsoft.EntityFrameworkCore;
using MySchoolProject.Date.Entities;
using MySchoolProject.Infrustructure.Data;
using MySchoolProject.Infrustructure.InfrustructureBases;
using MySchoolProject.Infrustructure.IRepositories;

namespace MySchoolProject.Infrustructure.Repositories
{
    public class DepartmentRepository : GenericRepositoryAsync<Department>, IDepartmentRepository
    {
        #region Fields
        private readonly DbSet<Department> _dbDepartment;

        #endregion

        #region Constructors
        public DepartmentRepository(ApplicationDbContext contxt) : base(contxt)
        {
            _dbDepartment = contxt.Set<Department>();
        }
        #endregion
        #region Handelfuntions

        #endregion
    }
}

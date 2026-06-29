using Microsoft.EntityFrameworkCore;
using MySchoolProject.Date.Entities.Views;
using MySchoolProject.Infrustructure.Data;
using MySchoolProject.Infrustructure.InfrustructureBases;
using MySchoolProject.Infrustructure.IRepositories.Views;

namespace MySchoolProject.Infrustructure.Repositories.Views
{
    public class ViewDepartmentRepository : GenericRepositoryAsync<ViewDepartment>, IViewRepository<ViewDepartment>
    {
        #region Fields
        private DbSet<ViewDepartment> viewDepartments;
        #endregion
        #region constructor
        public ViewDepartmentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            viewDepartments = dbContext.Set<ViewDepartment>();
        }
        #endregion
        #region handel func

        #endregion
    }
}

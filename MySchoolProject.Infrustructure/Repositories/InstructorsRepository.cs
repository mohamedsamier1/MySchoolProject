using Microsoft.EntityFrameworkCore;
using MySchoolProject.Date.Entities;
using MySchoolProject.Infrustructure.Data;
using MySchoolProject.Infrustructure.InfrustructureBases;
using MySchoolProject.Infrustructure.IRepositories;

namespace MySchoolProject.Infrustructure.Repositories
{
    public class InstructorsRepository : GenericRepositoryAsync<Instructor>, IInstructorsRepository
    {
        #region Fields
        private readonly DbSet<Instructor> _dbInstructor;

        #endregion

        #region Constructors
        public InstructorsRepository(ApplicationDbContext contxt) : base(contxt)
        {
            _dbInstructor = contxt.Set<Instructor>();
        }
        #endregion
        #region Handelfuntions

        #endregion
    }
}

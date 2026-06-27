using Microsoft.EntityFrameworkCore;
using MySchoolProject.Date.Entities.Identity;
using MySchoolProject.Infrustructure.Data;
using MySchoolProject.Infrustructure.InfrustructureBases;
using MySchoolProject.Infrustructure.IRepositories;

namespace MySchoolProject.Infrustructure.Repositories
{
    public class UserRepository : GenericRepositoryAsync<User>, IUserRepository
    {
        #region Fields
        private readonly DbSet<User> _dbSubject;

        #endregion

        #region Constructors
        public UserRepository(ApplicationDbContext contxt) : base(contxt)
        {
            _dbSubject = contxt.Set<User>();
        }
        #endregion
        #region Handelfuntions

        #endregion
    }
}

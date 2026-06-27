using Microsoft.EntityFrameworkCore;
using MySchoolProject.Date.Entities.Identity;
using MySchoolProject.Infrustructure.Data;
using MySchoolProject.Infrustructure.InfrustructureBases;
using MySchoolProject.Infrustructure.IRepositories;

namespace MySchoolProject.Infrustructure.Repositories
{
    public class RefreshTokenRepository : GenericRepositoryAsync<UserRefreshToken>, IRefreshTokenRepository
    {
        #region Filde
        private readonly DbSet<UserRefreshToken> _userRefreshToken;

        #endregion
        #region Constructor
        public RefreshTokenRepository(ApplicationDbContext contxt) : base(contxt)
        {
            _userRefreshToken = contxt.Set<UserRefreshToken>();
        }

        #endregion
        #region Handel func

        #endregion

    }
}

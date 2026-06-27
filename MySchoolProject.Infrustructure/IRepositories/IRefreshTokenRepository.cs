using MySchoolProject.Date.Entities.Identity;
using MySchoolProject.Infrustructure.InfrustructureBases;

namespace MySchoolProject.Infrustructure.IRepositories
{
    public interface IRefreshTokenRepository : IGenericRepositoryAsync<UserRefreshToken>
    {
    }
}

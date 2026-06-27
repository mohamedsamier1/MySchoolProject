using MySchoolProject.Infrustructure.IRepositories;
using MySchoolProject.Service.Abstracts;

namespace MySchoolProject.Service.Implementations
{
    public class UserService : IUserService
    {
        #region Fildes
        private readonly IUserRepository _userRepository;


        #endregion
        #region Constructor
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        #endregion
        #region Handel Func

        #endregion
    }
}

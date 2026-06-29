using MySchoolProject.Date.Entities.Identity;

namespace MySchoolProject.Service.AuthService.Abstract
{
    public interface ICurrentUserService
    {
        public int GetUserId();
        public Task<User> GetUser();
        public Task<List<string>> GetUserRoleAsync();
    }
}

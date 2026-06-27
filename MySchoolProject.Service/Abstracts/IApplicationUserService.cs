
using MySchoolProject.Date.Entities.Identity;

namespace MySchoolProject.Service.Abstracts
{
    public interface IApplicationUserService
    {
        public Task<string> AddUserAsync(User user, string Password);
    }
}

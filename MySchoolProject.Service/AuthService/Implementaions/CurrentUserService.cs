using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using MySchoolProject.Date.Entities.Identity;
using MySchoolProject.Service.AuthService.Abstract;
using System.Security.Claims;

namespace MySchoolProject.Service.AuthService.Implementaions
{
    public class CurrentUserService : ICurrentUserService
    {
        #region field
        private readonly IHttpContextAccessor _httpcontextAccessor;
        private readonly UserManager<User> _userManager;
        #endregion
        #region Const
        public CurrentUserService(IHttpContextAccessor httpcontextAccessor, UserManager<User> userManager)
        {
            _httpcontextAccessor = httpcontextAccessor;
            _userManager = userManager;
        }
        #endregion
        #region Function
        public int GetUserId()
        {
            var userId = _httpcontextAccessor.HttpContext?.User
                                                    .Claims
                                                    .SingleOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (userId == null)
            {
                throw new UnauthorizedAccessException();
            }
            return int.Parse(userId);
        }
        public async Task<User> GetUser()
        {
            var userid = GetUserId();
            var user = await _userManager.FindByIdAsync(userid.ToString());
            if (user == null)
            {
                throw new UnauthorizedAccessException();
            }
            return user;
        }

        public async Task<List<string>> GetUserRoleAsync()
        {
            var user = await GetUser();
            var role = await _userManager.GetRolesAsync(user);
            return role.ToList();
        }
        #endregion

    }
}

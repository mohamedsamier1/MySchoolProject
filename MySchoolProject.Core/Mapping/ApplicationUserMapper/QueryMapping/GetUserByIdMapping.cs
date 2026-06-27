using MySchoolProject.Core.Features.ApplicationUser.Queries.Response;
using MySchoolProject.Date.Entities.Identity;

namespace MySchoolProject.Core.Mapping.ApplicationUserMapper
{
    public partial class ApplicationUserProfile
    {
        public void GetUserByIdMapping()
        {
            CreateMap<User, GetUserByIdResponse>();
        }
    }
}

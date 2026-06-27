using MySchoolProject.Core.Features.ApplicationUser.Commands.Models;
using MySchoolProject.Date.Entities.Identity;

namespace MySchoolProject.Core.Mapping.ApplicationUserMapper
{
    public partial class ApplicationUserProfile
    {
        public void CreateUserMapping()
        {
            CreateMap<AddUserCommand, User>()
                .ForMember(des => des.PhoneNumber, opt => opt.MapFrom(src => src.Phone));
        }
    }
}

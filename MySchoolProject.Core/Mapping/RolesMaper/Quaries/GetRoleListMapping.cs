using MySchoolProject.Core.Features.Authorization.Quaries.Result;
using MySchoolProject.Date.Entities.Identity;

namespace MySchoolProject.Core.Mapping.RolesMaper
{
    public partial class RoleProfile
    {
        public void GetRoleListMapping()
        {
            CreateMap<Role, GetRoleResponse>()
                .ForMember(des => des.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(des => des.RoleName, opt => opt.MapFrom(src => src.Name));

        }
    }
}

using AutoMapper;

namespace MySchoolProject.Core.Mapping.RolesMaper
{
    public partial class RoleProfile : Profile
    {
        public RoleProfile()
        {
            GetRoleListMapping();
            GetRoleByIdMapping();
        }
    }
}

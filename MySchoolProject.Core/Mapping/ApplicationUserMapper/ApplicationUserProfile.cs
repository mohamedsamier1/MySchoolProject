using AutoMapper;

namespace MySchoolProject.Core.Mapping.ApplicationUserMapper
{
    public partial class ApplicationUserProfile : Profile
    {
        public ApplicationUserProfile()
        {
            CreateUserMapping();
            GetUserPaginationMapper();
            GetUserByIdMapping();
            UpdateUserMapping();
        }
    }
}

using MySchoolProject.Core.Features.Department.Queries.Results;
using MySchoolProject.Date.Entities.Views;

namespace MySchoolProject.Core.Mapping.DepartmentMaper
{
    public partial class DepartmenProFile
    {
        public void GetDepartemtStudentCount()
        {
            CreateMap<ViewDepartment, GetDepartemtStudentCountResults>()
               .ForMember(des => des.Name, opt => opt.MapFrom(src => src.GenerallLocalizedName(src.DNameAr, src.DNameEn)))
               .ForMember(des => des.StudentCount, opt => opt.MapFrom(src => src.StudentCount));
        }
    }
}

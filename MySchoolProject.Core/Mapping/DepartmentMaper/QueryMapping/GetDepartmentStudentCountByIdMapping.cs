using MySchoolProject.Core.Features.Department.Queries.Models;
using MySchoolProject.Core.Features.Department.Queries.Results;
using MySchoolProject.Date.Entities.Procedures;

namespace MySchoolProject.Core.Mapping.DepartmentMaper
{
    public partial class DepartmenProFile
    {

        public void GetDepartmentStudentCountByIdMapping()
        {
            CreateMap<GetDepartmentStudentCounteByIdQuery, DepartmentStudentCountProcParameters>();
            CreateMap<DepartmentStudentCountProc, GetDepartmentStudentCounteByIdResult>()
                .ForMember(des => des.Name, opt => opt.MapFrom(src => src.GenerallLocalizedName(src.DNameAr, src.DNameEn)))
               .ForMember(des => des.StudentCount, opt => opt.MapFrom(src => src.StudentCount));

        }
    }
}

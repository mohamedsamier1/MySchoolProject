using MySchoolProject.Core.Features.Students.Queries.Results;
using MySchoolProject.Date.Entities;

namespace MySchoolProject.Core.Mapping.StudentMaper
{
    public partial class StudentProfile
    {
        public void GetStudneByIdMapping()
        {
            CreateMap<Student, GetStudentByIdResponse>().
               ForMember(des => des.DepatmentName, opt => opt.MapFrom(src => src.GenerallLocalizedName(src.Department.DNameAr, src.Department.DNameEn)))
               .ForMember(des => des.Name, opt => opt.MapFrom(src => src.GenerallLocalizedName(src.NameAr, src.NameEn)));
        }
    }
}

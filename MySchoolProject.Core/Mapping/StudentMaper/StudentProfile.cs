using AutoMapper;

namespace MySchoolProject.Core.Mapping.StudentMaper
{
    public partial class StudentProfile : Profile
    {
        public StudentProfile()
        {
            GetStudnetListMapping();
            GetStudneByIdMapping();
            AddStudentCommandMapping();
            EditStudentCommandMapping();
        }
    }
}

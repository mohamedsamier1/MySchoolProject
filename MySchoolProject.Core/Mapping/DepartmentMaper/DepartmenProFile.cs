using AutoMapper;

namespace MySchoolProject.Core.Mapping.DepartmentMaper
{
    public partial class DepartmenProFile : Profile
    {
        public DepartmenProFile()
        {
            GetDepartmentByIdMapping();
            GetDepartemtStudentCount();
            GetDepartmentStudentCountByIdMapping();
        }
    }
}

using MySchoolProject.Core.Features.Instructors.Command.Models;
using MySchoolProject.Date.Entities;

namespace MySchoolProject.Core.Mapping.InstructorMapper
{
    public partial class InstructoorProfile
    {
        public void AddInstructorMapping()
        {
            CreateMap<AddInstructorCommand, Instructor>()
               .ForMember(des => des.Image, opt => opt.Ignore());

        }
    }
}

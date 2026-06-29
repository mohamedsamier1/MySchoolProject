using MediatR;
using MySchoolProject.Core.Bases;
using MySchoolProject.Core.Features.Department.Queries.Results;

namespace MySchoolProject.Core.Features.Department.Queries.Models
{
    public class GetDepartmentStudentCounteByIdQuery : IRequest<Response<GetDepartmentStudentCounteByIdResult>>
    {
        public int DId { get; set; }
    }
}

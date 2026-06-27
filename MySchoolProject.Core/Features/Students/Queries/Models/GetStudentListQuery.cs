using MediatR;
using MySchoolProject.Core.Bases;
using MySchoolProject.Core.Features.Students.Queries.Results;

namespace MySchoolProject.Core.Features.Students.Queries.Models
{
    public class GetStudentListQuery : IRequest<Response<List<GetStudentListResponse>>>
    {

    }
}

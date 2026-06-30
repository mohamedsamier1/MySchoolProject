using MediatR;
using MySchoolProject.Core.Bases;

namespace MySchoolProject.Core.Features.Instructors.Queries.Models
{
    public class GetSummationSalaryInstructorQuery : IRequest<Response<decimal>>
    {

    }
}

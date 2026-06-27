using MediatR;
using MySchoolProject.Core.Bases;
using MySchoolProject.Core.Features.Department.Queries.Results;

namespace MySchoolProject.Core.Features.Department.Queries.Models
{
    public class GetDepartmentByIdQuery : IRequest<Response<GetDepartmentByIdResponse>>
    {
        public int Id { get; set; }
        public int StudentPageNumber { get; set; }
        public int StudentPageSize { get; set; }
    }
}

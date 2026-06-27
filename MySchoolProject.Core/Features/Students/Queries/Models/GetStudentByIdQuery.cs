using MediatR;
using MySchoolProject.Core.Bases;
using MySchoolProject.Core.Features.Students.Queries.Results;

namespace MySchoolProject.Core.Features.Students.Queries.Models
{
    public class GetStudentByIdQuery : IRequest<Response<GetStudentByIdResponse>>
    {
        public int Id { get; set; }
        public GetStudentByIdQuery(int id)
        {
            Id = id;
        }
    }
}

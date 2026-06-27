using MediatR;
using MySchoolProject.Core.Bases;
using MySchoolProject.Core.Features.ApplicationUser.Queries.Response;

namespace MySchoolProject.Core.Features.ApplicationUser.Queries.Models
{
    public class GetUserByIdQuery : IRequest<Response<GetUserByIdResponse>>
    {
        public int Id { get; set; }
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }
    }
}

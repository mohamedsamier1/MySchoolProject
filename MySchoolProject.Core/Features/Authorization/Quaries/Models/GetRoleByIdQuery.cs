using MediatR;
using MySchoolProject.Core.Bases;
using MySchoolProject.Core.Features.Authorization.Quaries.Result;

namespace MySchoolProject.Core.Features.Authorization.Quaries.Models
{
    public class GetRoleByIdQuery : IRequest<Response<GetRoleByIdResponse>>
    {
        public int Id { get; set; }

        public GetRoleByIdQuery(int id)
        {
            Id = id;
        }


    }
}

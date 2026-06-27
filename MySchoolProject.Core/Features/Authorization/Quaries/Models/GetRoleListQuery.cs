using MediatR;
using MySchoolProject.Core.Bases;
using MySchoolProject.Core.Features.Authorization.Quaries.Result;

namespace MySchoolProject.Core.Features.Authorization.Quaries.Models
{
    public class GetRoleListQuery : IRequest<Response<List<GetRoleResponse>>>
    {
    }
}

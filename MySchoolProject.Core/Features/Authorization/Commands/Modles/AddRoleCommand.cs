using MediatR;
using MySchoolProject.Core.Bases;

namespace MySchoolProject.Core.Features.Authorization.Commands.Modles
{
    public class AddRoleCommand : IRequest<Response<string>>
    {
        public string RoleName { get; set; }
    }
}

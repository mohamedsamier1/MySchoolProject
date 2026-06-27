using MediatR;
using MySchoolProject.Core.Bases;

namespace MySchoolProject.Core.Features.Authorization.Commands.Modles
{
    public class EditRoleCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

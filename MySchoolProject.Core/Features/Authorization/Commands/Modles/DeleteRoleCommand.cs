using MediatR;
using MySchoolProject.Core.Bases;

namespace MySchoolProject.Core.Features.Authorization.Commands.Modles
{
    public class DeleteRoleCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }

        public DeleteRoleCommand(int id)
        {
            Id = id;
        }


    }
}

using MediatR;
using MySchoolProject.Core.Bases;
using MySchoolProject.Date.DTOS;

namespace MySchoolProject.Core.Features.Authorization.Commands.Modles
{
    public class UpdateUserRolesCommand : UpdateUserRolesDto, IRequest<Response<string>>
    {

    }

}

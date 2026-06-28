using MediatR;
using MySchoolProject.Core.Bases;

namespace MySchoolProject.Core.Features.Authentication.Commands.Models
{
    public class ResetPasswordCommand : IRequest<Response<string>>
    {
        public string Email { get; set; }
    }
}

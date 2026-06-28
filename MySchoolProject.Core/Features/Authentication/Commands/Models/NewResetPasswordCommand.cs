using MediatR;
using MySchoolProject.Core.Bases;

namespace MySchoolProject.Core.Features.Authentication.Commands.Models
{
    public class NewResetPasswordCommand : IRequest<Response<string>>
    {
        public string Email { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
}

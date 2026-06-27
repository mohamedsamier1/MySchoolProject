using MediatR;
using MySchoolProject.Core.Bases;
using MySchoolProject.Date.Helpers;

namespace MySchoolProject.Core.Features.Authentication.Commands.Models
{
    public class SignInCommand : IRequest<Response<JwtAuthResult>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

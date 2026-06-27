using MediatR;
using MySchoolProject.Core.Bases;
using MySchoolProject.Date.Helpers;

namespace MySchoolProject.Core.Features.Authentication.Commands.Models
{
    public class RefreshTokenCommand : IRequest<Response<JwtAuthResult>>
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}

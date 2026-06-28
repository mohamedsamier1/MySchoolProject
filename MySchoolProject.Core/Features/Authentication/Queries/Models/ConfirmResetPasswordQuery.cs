using MediatR;
using MySchoolProject.Core.Bases;

namespace MySchoolProject.Core.Features.Authentication.Queries.Models
{
    public class ConfirmResetPasswordQuery : IRequest<Response<string>>
    {
        public string Email { get; set; }
        public string code { get; set; }
    }
}

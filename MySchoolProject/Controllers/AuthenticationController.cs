using Microsoft.AspNetCore.Mvc;
using MySchoolProject.APi.Base;
using MySchoolProject.Core.Features.Authentication.Commands.Models;
using MySchoolProject.Core.Features.Authentication.Queries.Models;
using MySchoolProject.Date.AppMetaData;

namespace MySchoolProject.APi.Controllers
{

    [ApiController]
    public class AuthenticationController : AppBaseController
    {
        [HttpPost(Router.Authentication.SignIn)]
        public async Task<IActionResult> SignIn([FromBody] SignInCommand command)
        {
            var response = await _mediator.Send(command);
            return NewResult(response);
        }
        [HttpPost(Router.Authentication.RefreshToken)]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenCommand command)
        {
            var response = await _mediator.Send(command);
            return NewResult(response);
        }
        [HttpGet(Router.Authentication.ValidateToken)]
        public async Task<IActionResult> ValidateToken([FromQuery] AuthorizeUserQuery query)
        {
            var response = await _mediator.Send(query);
            return NewResult(response);
        }
        [HttpGet(Router.Authentication.ConfirmEmail)]
        public async Task<IActionResult> ConfirmEmail([FromQuery] ConfirmEmailQuery query)
        {
            var response = await _mediator.Send(query);
            return NewResult(response);
        }
        [HttpGet(Router.Authentication.ConfirmResetPasswordCode)]
        public async Task<IActionResult> ConfirmResetPasswordCode([FromQuery] ConfirmResetPasswordQuery query)
        {
            var response = await _mediator.Send(query);
            return NewResult(response);
        }
        [HttpPost(Router.Authentication.SendToResetPasswordByEmail)]
        public async Task<IActionResult> SendToResetPasswordByEmail([FromBody] ResetPasswordCommand command)
        {
            var response = await _mediator.Send(command);
            return NewResult(response);
        }
        [HttpPost(Router.Authentication.NewPassword)]
        public async Task<IActionResult> NewResetPassword([FromBody] NewResetPasswordCommand command)
        {
            var response = await _mediator.Send(command);
            return NewResult(response);
        }
    }
}

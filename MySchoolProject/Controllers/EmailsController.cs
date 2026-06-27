using Microsoft.AspNetCore.Mvc;
using MySchoolProject.APi.Base;
using MySchoolProject.Core.Features.Emails.Commands.Models;
using MySchoolProject.Date.AppMetaData;

namespace MySchoolProject.APi.Controllers
{

    [ApiController]
    public class EmailsController : AppBaseController
    {
        [HttpPost(Router.Emails.SendEmail)]
        public async Task<IActionResult> SendEmail([FromQuery] SendEmailCommand command)
        {
            var resutl = await _mediator.Send(command);
            return NewResult(resutl);
        }
    }
}

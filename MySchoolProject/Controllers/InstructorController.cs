using Microsoft.AspNetCore.Mvc;
using MySchoolProject.APi.Base;
using MySchoolProject.Core.Features.Instructors.Command.Models;
using MySchoolProject.Core.Features.Instructors.Queries.Models;
using MySchoolProject.Date.AppMetaData;

namespace MySchoolProject.APi.Controllers
{

    [ApiController]
    public class InstructorController : AppBaseController
    {
        [HttpGet(Router.InstructorRouting.GetSummationSalaryOfInstructor)]
        public async Task<IActionResult> GetSummationSalaryOfInstructor()
        {
            return NewResult(await _mediator.Send(new GetSummationSalaryInstructorQuery()));
        }
        [HttpPost(Router.InstructorRouting.AddInstructor)]
        public async Task<IActionResult> AddInstructor([FromForm] AddInstructorCommand command)
        {
            return NewResult(await _mediator.Send(command));
        }
    }
}

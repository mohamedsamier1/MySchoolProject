using Microsoft.AspNetCore.Mvc;
using MySchoolProject.APi.Base;
using MySchoolProject.Core.Features.Department.Queries.Models;
using MySchoolProject.Date.AppMetaData;

namespace MySchoolProject.APi.Controllers
{

    [ApiController]
    public class DepartmentController : AppBaseController
    {
        [HttpGet(Router.DepartmentRouting.GetDepartmentById)]
        public async Task<IActionResult> GetDepartmentById([FromQuery] GetDepartmentByIdQuery query)
        {
            return NewResult(await _mediator.Send(query));
        }
        [HttpGet(Router.DepartmentRouting.GetDepartmentStudentCount)]
        public async Task<IActionResult> GetDepartmentStudentCount()
        {
            return NewResult(await _mediator.Send(new GetDepartemtStudentCountQuery()));
        }
        [HttpGet(Router.DepartmentRouting.GetDepartmentStudentCountById)]
        public async Task<IActionResult> GetDepartmentStudentCountById([FromRoute] int id)
        {
            return NewResult(await _mediator.Send(new GetDepartmentStudentCounteByIdQuery() { DId = id }));
        }
    }
}

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
    }
}

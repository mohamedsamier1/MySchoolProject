using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using MySchoolProject.Core.Bases;
using MySchoolProject.Core.Features.Department.Queries.Models;
using MySchoolProject.Core.Features.Department.Queries.Results;
using MySchoolProject.Core.ShResources;
using MySchoolProject.Core.Wrappers;
using MySchoolProject.Date.Entities;
using MySchoolProject.Date.Entities.Procedures;
using MySchoolProject.Service.Abstracts;
using System.Linq.Expressions;

namespace MySchoolProject.Core.Features.Department.Queries.Handlers
{
    public class DepartmentQueryHandler : ResponseHandler,
                IRequestHandler<GetDepartmentByIdQuery, Response<GetDepartmentByIdResponse>>,
                IRequestHandler<GetDepartemtStudentCountQuery, Response<List<GetDepartemtStudentCountResults>>>,
                IRequestHandler<GetDepartmentStudentCounteByIdQuery, Response<GetDepartmentStudentCounteByIdResult>>
    {
        #region Filde
        private readonly IStringLocalizer<SharedResources> _stringLocalizer;
        private readonly IMapper _mapper;
        private readonly IDepartmentService _departmentService;
        private readonly IStudentService _studentService;
        #endregion
        #region Constractor
        public DepartmentQueryHandler(IStringLocalizer<SharedResources> stringLocalizer, IMapper mapper, IDepartmentService departmentService, IStudentService studentService) : base(stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
            _mapper = mapper;
            _departmentService = departmentService;
            _studentService = studentService;
        }


        #endregion
        #region Handel function
        public async Task<Response<GetDepartmentByIdResponse>> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            var department = await _departmentService.GetDepartmentById(request.Id);
            if (department == null) return NotFound<GetDepartmentByIdResponse>(_stringLocalizer[SharedResourcesKeys.NotFound]);
            var mapper = _mapper.Map<GetDepartmentByIdResponse>(department);
            //pagination
            Expression<Func<Student, StudentResponse>> expression = e => new StudentResponse(e.Id, e.GenerallLocalizedName(e.NameAr, e.NameEn));
            var studentQuery = _studentService.GetStudentByDepartmentIdQuerable(request.Id);
            var paginatedlist = await studentQuery.Select(expression).ToPaginatedListAsync(request.StudentPageNumber, request.StudentPageSize);
            mapper.StudentList = paginatedlist;
            return Success(mapper);
        }

        public async Task<Response<List<GetDepartemtStudentCountResults>>> Handle(GetDepartemtStudentCountQuery request, CancellationToken cancellationToken)
        {
            var viewDepartmentresult = await _departmentService.GetViewDepartment();
            var mapper = _mapper.Map<List<GetDepartemtStudentCountResults>>(viewDepartmentresult);
            return Success(mapper);
        }

        public async Task<Response<GetDepartmentStudentCounteByIdResult>> Handle(GetDepartmentStudentCounteByIdQuery request, CancellationToken cancellationToken)
        {
            var parameter = _mapper.Map<DepartmentStudentCountProcParameters>(request);
            var prosresult = await _departmentService.GetDepartmentStudentCountProcs(parameter);
            var result = _mapper.Map<GetDepartmentStudentCounteByIdResult>(prosresult.FirstOrDefault());
            return Success(result);

        }


        #endregion
    }
}

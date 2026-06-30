using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using MySchoolProject.Core.Bases;
using MySchoolProject.Core.Features.Instructors.Queries.Models;
using MySchoolProject.Core.ShResources;
using MySchoolProject.Service.Abstracts;

namespace MySchoolProject.Core.Features.Instructors.Queries.Handlers
{
    public class InstructoerQueryHandler : ResponseHandler,
        IRequestHandler<GetSummationSalaryInstructorQuery, Response<decimal>>
    {
        #region feides
        private readonly IStringLocalizer<SharedResources> _stringLocalizer;
        private readonly IInstructorService _instructorService;


        private readonly IMapper _mapper;
        #endregion
        #region Ctor
        public InstructoerQueryHandler(IStringLocalizer<SharedResources> stringLocalizer, IMapper mapper, IInstructorService instructorService) : base(stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
            _mapper = mapper;
            _instructorService = instructorService;
        }


        #endregion
        #region HandelFunction
        public async Task<Response<decimal>> Handle(GetSummationSalaryInstructorQuery request, CancellationToken cancellationToken)
        {
            var result = await _instructorService.GetSummationSalaryofInstructor();
            return Success(result);
        }
        #endregion
    }
}

using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using MySchoolProject.Core.Bases;
using MySchoolProject.Core.Features.Instructors.Command.Models;
using MySchoolProject.Core.ShResources;
using MySchoolProject.Date.Entities;
using MySchoolProject.Service.Abstracts;

namespace MySchoolProject.Core.Features.Instructors.Command.Handlers
{
    public class InstructorCommandHandler : ResponseHandler,
                                             IRequestHandler<AddInstructorCommand, Response<string>>
    {
        #region Feilds
        private readonly IStringLocalizer<SharedResources> _stringLocalizer;
        private readonly IMapper _mapper;
        private readonly IInstructorService _instructorService;
        #endregion
        #region Constructor
        public InstructorCommandHandler(IStringLocalizer<SharedResources> stringLocalizer, IMapper mapper, IInstructorService instructorService) : base(stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;

            _mapper = mapper;
            _instructorService = instructorService;
        }
        #endregion
        #region Handel func
        public async Task<Response<string>> Handle(AddInstructorCommand request, CancellationToken cancellationToken)
        {
            var mappInstructor = _mapper.Map<Instructor>(request);
            var result = await _instructorService.AddInstructorAsync(mappInstructor, request.Image);
            switch (result)
            {

                case "NoImage": return BadRequest<string>(_stringLocalizer[SharedResourcesKeys.NoImage]);
                case "FailedToUploudImage": return BadRequest<string>(_stringLocalizer[SharedResourcesKeys.FailedToUploudImage]);
                case "FailedInAdd": return BadRequest<string>(_stringLocalizer[SharedResourcesKeys.FailedInAdd]);

            }
            return Success<string>(_stringLocalizer[SharedResourcesKeys.Success]);
        }
        #endregion

    }
}

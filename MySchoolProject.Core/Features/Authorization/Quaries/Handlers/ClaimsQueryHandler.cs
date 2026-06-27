using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using MySchoolProject.Core.Bases;
using MySchoolProject.Core.Features.Authorization.Quaries.Models;
using MySchoolProject.Core.ShResources;
using MySchoolProject.Date.DTOS;
using MySchoolProject.Date.Entities.Identity;
using MySchoolProject.Service.Abstracts;

namespace MySchoolProject.Core.Features.Authorization.Quaries.Handlers
{
    public class ClaimsQueryHandler : ResponseHandler,
                                    IRequestHandler<ManageUserClaimsQuery, Response<ManagUserClaimsDto>>
    {
        #region Fileds
        public readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _stringLocalizer;
        private readonly IAuthorizationService _authorizationService;
        private readonly UserManager<User> _userManager;
        #endregion
        #region Constructors
        public ClaimsQueryHandler(IMapper mapper, IStringLocalizer<SharedResources> stringLocalizer, IAuthorizationService authorizationService, UserManager<User> userManager) : base(stringLocalizer)
        {
            _mapper = mapper;
            _stringLocalizer = stringLocalizer;
            _authorizationService = authorizationService;
            _userManager = userManager;
        }
        #endregion
        #region Handle Functions
        public async Task<Response<ManagUserClaimsDto>> Handle(ManageUserClaimsQuery request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId.ToString());
            if (user == null) return NotFound<ManagUserClaimsDto>(_stringLocalizer[SharedResourcesKeys.NotFoundUserId]);
            var result = await _authorizationService.ManageUserClaimData(user);
            return Success(result);
        }
        #endregion
    }
}

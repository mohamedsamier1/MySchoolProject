using MediatR;
using Microsoft.Extensions.Localization;
using MySchoolProject.Core.Bases;
using MySchoolProject.Core.Features.Authentication.Queries.Models;
using MySchoolProject.Core.ShResources;
using MySchoolProject.Service.Abstracts;

namespace MySchoolProject.Core.Features.Authentication.Queries.Handlers
{
    public class AuthenticationQueryHandler : ResponseHandler,
        IRequestHandler<AuthorizeUserQuery, Response<string>>,
        IRequestHandler<ConfirmEmailQuery, Response<string>>,
        IRequestHandler<ConfirmResetPasswordQuery, Response<string>>
    {

        #region filde

        private readonly IStringLocalizer<SharedResources> _stringLocalizer;

        private readonly IAuthenticationService _authenticationService;
        #endregion
        #region Constractor
        public AuthenticationQueryHandler(IStringLocalizer<SharedResources> stringLocalizer, IAuthenticationService authenticationService) : base(stringLocalizer)
        {

            _stringLocalizer = stringLocalizer;

            _authenticationService = authenticationService;
        }
        #endregion
        #region Handle fuc
        public async Task<Response<string>> Handle(AuthorizeUserQuery request, CancellationToken cancellationToken)
        {
            var result = await _authenticationService.ValidateToken(request.AccessToken);
            if (result == "NotExpired") return Success(result);
            return Unauthorized<string>(_stringLocalizer[SharedResourcesKeys.TokenisExpired]);
        }

        public async Task<Response<string>> Handle(ConfirmEmailQuery request, CancellationToken cancellationToken)
        {
            var confirmEmail = await _authenticationService.ConfirmEmail(request.UserId, request.Code);

            return Success(confirmEmail);
        }

        public async Task<Response<string>> Handle(ConfirmResetPasswordQuery request, CancellationToken cancellationToken)
        {
            var result = await _authenticationService.ConfirmResetPassworedCode(request.Email, request.code);
            switch (result)
            {
                case "NotFoundEmail": return BadRequest<string>(_stringLocalizer[SharedResourcesKeys.NotFoundEmail]);
                case "InvalidCode": return BadRequest<string>(_stringLocalizer[SharedResourcesKeys.InvalidCode]);
                case "SuccessCode": return Success<string>(_stringLocalizer[SharedResourcesKeys.SuccessCode]);
                default:
                    return BadRequest<string>(_stringLocalizer[SharedResourcesKeys.CheakTheCode]);

            }
        }
        #endregion
    }
}

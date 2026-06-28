using FluentValidation;
using Microsoft.Extensions.Localization;
using MySchoolProject.Core.Features.Authentication.Queries.Models;
using MySchoolProject.Core.ShResources;

namespace MySchoolProject.Core.Features.Authentication.Queries.Validator
{
    public class ConfirmResetPasswordValidator : AbstractValidator<ConfirmResetPasswordQuery>
    {
        #region Fields
        private readonly IStringLocalizer<SharedResources> _stringLocalizer;
        #endregion
        #region constractors
        public ConfirmResetPasswordValidator(IStringLocalizer<SharedResources> stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
            ApplyValidationsRules();
            ApplyCustomValidationsRules();

        }
        #endregion
        #region actions
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Email)
              .NotEmpty().WithMessage(_stringLocalizer[SharedResourcesKeys.NotEmpty])
              .NotNull().WithMessage(_stringLocalizer[SharedResourcesKeys.NotNull]);

            RuleFor(x => x.code)
                .NotEmpty().WithMessage(_stringLocalizer[SharedResourcesKeys.NotEmpty])
                .NotNull().WithMessage(_stringLocalizer[SharedResourcesKeys.NotNull]);


        }
        public void ApplyCustomValidationsRules()
        {

        }
        #endregion
    }
}

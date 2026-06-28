using FluentValidation;
using Microsoft.Extensions.Localization;
using MySchoolProject.Core.Features.Authentication.Commands.Models;
using MySchoolProject.Core.ShResources;

namespace MySchoolProject.Core.Features.Authentication.Commands.Validatiors
{
    public class ResetPasswordValidatior : AbstractValidator<ResetPasswordCommand>
    {
        #region Fields
        private readonly IStringLocalizer<SharedResources> _stringLocalizer;
        #endregion
        #region constractors
        public ResetPasswordValidatior(IStringLocalizer<SharedResources> stringLocalizer)
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
              .NotNull().WithMessage(_stringLocalizer[SharedResourcesKeys.NotNull])
              .MaximumLength(100);


        }
        public void ApplyCustomValidationsRules()
        {

        }
        #endregion
    }
}

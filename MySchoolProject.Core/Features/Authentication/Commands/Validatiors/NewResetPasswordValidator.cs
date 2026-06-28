using FluentValidation;
using Microsoft.Extensions.Localization;
using MySchoolProject.Core.Features.Authentication.Commands.Models;
using MySchoolProject.Core.ShResources;

namespace MySchoolProject.Core.Features.Authentication.Commands.Validatiors
{
    public class NewResetPasswordValidator : AbstractValidator<NewResetPasswordCommand>
    {
        #region Fields
        private readonly IStringLocalizer<SharedResources> _stringLocalizer;
        #endregion
        #region constractors
        public NewResetPasswordValidator(IStringLocalizer<SharedResources> stringLocalizer)
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
            RuleFor(x => x.NewPassword)
              .NotEmpty().WithMessage(_stringLocalizer[SharedResourcesKeys.NotEmpty])
              .NotNull().WithMessage(_stringLocalizer[SharedResourcesKeys.NotNull]);

            RuleFor(x => x.ConfirmPassword)
              .NotEmpty().WithMessage(_stringLocalizer[SharedResourcesKeys.NotEmpty])
              .NotNull().WithMessage(_stringLocalizer[SharedResourcesKeys.NotNull])
              .Equal(x => x.NewPassword).WithMessage(_stringLocalizer[SharedResourcesKeys.PasswordNotEqualConfirmePassword]);



        }
        public void ApplyCustomValidationsRules()
        {

        }
        #endregion
    }
}

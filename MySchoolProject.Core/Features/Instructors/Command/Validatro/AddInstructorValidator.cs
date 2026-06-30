using FluentValidation;
using Microsoft.Extensions.Localization;
using MySchoolProject.Core.Features.Instructors.Command.Models;
using MySchoolProject.Core.ShResources;
using MySchoolProject.Service.Abstracts;

namespace MySchoolProject.Core.Features.Instructors.Command.Validatro
{
    public class AddInstructorValidator : AbstractValidator<AddInstructorCommand>
    {
        #region Fields
        private readonly IStringLocalizer<SharedResources> _stringLocalizer;
        private readonly IDepartmentService _departmentService;
        #endregion
        #region constractors
        public AddInstructorValidator(IStringLocalizer<SharedResources> stringLocalizer, IDepartmentService departmentService)
        {
            _stringLocalizer = stringLocalizer;
            ApplyValidationsRules();
            ApplyCustomValidationsRules();
            _departmentService = departmentService;
        }
        #endregion
        #region actions
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.NameAr)
                .NotEmpty().WithMessage(_stringLocalizer[SharedResourcesKeys.NotEmpty])
                .NotNull().WithMessage(_stringLocalizer[SharedResourcesKeys.Required])
                .MaximumLength(50);
            RuleFor(x => x.NameEn)
                 .NotEmpty().WithMessage(_stringLocalizer[SharedResourcesKeys.NotEmpty])
                .NotNull().WithMessage(_stringLocalizer[SharedResourcesKeys.Required])
                .MaximumLength(50);
            RuleFor(x => x.Address)
                .NotEmpty().WithMessage(_stringLocalizer[SharedResourcesKeys.NotEmpty])
                .NotNull().WithMessage(_stringLocalizer[SharedResourcesKeys.Required])
                .MaximumLength(50);
            RuleFor(x => x.Salary)
                .NotEmpty().WithMessage(_stringLocalizer[SharedResourcesKeys.NotEmpty])
                .NotNull().WithMessage(_stringLocalizer[SharedResourcesKeys.Required]);
            RuleFor(x => x.DId)
                .NotEmpty().WithMessage(_stringLocalizer[SharedResourcesKeys.NotEmpty])
                .NotNull().WithMessage(_stringLocalizer[SharedResourcesKeys.Required]);

        }
        public void ApplyCustomValidationsRules()
        {
            RuleFor(x => x.DId)
                .MustAsync(async (Key, CancellationToken) => await _departmentService.IsDepartmentIdExist(Key))
                .WithMessage(_stringLocalizer[SharedResourcesKeys.NotFoundId]);
        }
        #endregion
    }
}

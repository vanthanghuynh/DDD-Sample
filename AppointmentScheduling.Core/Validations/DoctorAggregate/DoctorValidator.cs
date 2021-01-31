using AppointmentScheduling.Core.AggregatesModel;
using AppointmentScheduling.Core.Constants;
using FluentValidation;

namespace AppointmentScheduling.Core.Validations
{
    public class DoctorValidator : AbstractValidator<Doctor>
    {
        public DoctorValidator()
        {
            RuleFor(d => d.FirstName)
                .NotEmpty()
                .WithMessage(ErrorMessages.ERR_VALIDATION_DOCTOR_FIRST_NAME_EMPTY);

            RuleFor(d => d.LastName)
                .NotEmpty()
                .WithMessage(ErrorMessages.ERR_VALIDATION_DOCTOR_LAST_NAME_EMPTY);
        }
    }
}

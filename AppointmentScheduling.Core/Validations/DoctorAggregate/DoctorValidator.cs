using AppointmentScheduling.Core.AggregatesModel.DoctorAggregate;
using AppointmentScheduling.Core.Constants;
using FluentValidation;

namespace AppointmentScheduling.Core.Validations.DoctorAggregate
{
    public class DoctorValidator : AbstractValidator<Doctor>
    {
        public DoctorValidator()
        {
            RuleFor(d => d.FisrtName)
                .NotEmpty()
                .WithMessage(ErrorMessages.ERR_VALIDATION_DOCTOR_FIRST_NAME_EMPTY);

            RuleFor(d => d.LastName)
                .NotEmpty()
                .WithMessage(ErrorMessages.ERR_VALIDATION_DOCTOR_LAST_NAME_EMPTY);
        }
    }
}

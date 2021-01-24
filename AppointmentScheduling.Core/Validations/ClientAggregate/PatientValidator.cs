using AppointmentScheduling.Core.AggregatesModel.ClientAggregate;
using AppointmentScheduling.Core.Constants;
using FluentValidation;

namespace AppointmentScheduling.Core.Validations.ClientAggregate
{
    public class PatientValidator : AbstractValidator<Patient>
    {
        public PatientValidator()
        {
            RuleFor(p => p.ClientId)
                .NotNull()
                .WithMessage(ErrorMessages.ERR_VALIDATION_PATIENT_CLIENT_ID_NULL);

            RuleFor(p => p.AnimalType)
                .NotNull()
                .WithMessage(ErrorMessages.ERR_VALIDATION_PATIENT_ANIMAL_TYPE_NULL);

            RuleFor(p => p.GenderType)
                .NotNull()
                .WithMessage(ErrorMessages.ERR_VALIDATION_PATIENT_GENDER_TYPE_NULL);
        }
    }
}

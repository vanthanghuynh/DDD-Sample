using AppointmentScheduling.Core.AggregatesModel;
using AppointmentScheduling.Core.Constants;
using FluentValidation;

namespace AppointmentScheduling.Core.Validations
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

            RuleFor(p => p.Gender)
                .NotNull()
                .WithMessage(ErrorMessages.ERR_VALIDATION_PATIENT_GENDER_TYPE_NULL);
        }
    }
}

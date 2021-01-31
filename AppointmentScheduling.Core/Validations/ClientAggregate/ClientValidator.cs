using AppointmentScheduling.Core.AggregatesModel;
using AppointmentScheduling.Core.Constants;
using FluentValidation;

namespace AppointmentScheduling.Core.Validations
{
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(c => c.FirstName)
                .NotEmpty()
                .WithMessage(ErrorMessages.ERR_VALIDATION_CLIENT_FIRST_NAME_EMPTY);

            RuleFor(c => c.LastName)
                .NotEmpty()
                .WithMessage(ErrorMessages.ERR_VALIDATION_CLIENT_LAST_NAME_EMPTY);

            RuleForEach(c => c.Patients)
                .NotEmpty()
                .SetValidator(new PatientValidator());
        }
    }
}

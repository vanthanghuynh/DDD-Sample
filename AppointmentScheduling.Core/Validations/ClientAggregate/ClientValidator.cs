using AppointmentScheduling.Core.AggregatesModel.ClientAggregate;
using AppointmentScheduling.Core.Constants;
using FluentValidation;

namespace AppointmentScheduling.Core.Validations.ClientAggregate
{
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(c => c.FullName)
                .NotEmpty()
                .WithMessage(ErrorMessages.ERR_VALIDATION_CLIENT_FULLNAME_EMPTY);

            RuleForEach(c => c.Patients)
                .NotEmpty()
                .SetValidator(new PatientValidator());
        }
    }
}

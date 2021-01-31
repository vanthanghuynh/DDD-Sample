using AppointmentScheduling.Core.AggregatesModel;
using AppointmentScheduling.Core.Constants;
using FluentValidation;

namespace AppointmentScheduling.Core.Validations
{
    public class ScheduleValidator : AbstractValidator<Schedule>
    {
        public ScheduleValidator()
        {
            RuleFor(s => s.ClinicId)
                .NotNull()
                .WithMessage(ErrorMessages.ERR_VALIDATION_SCHEDULE_CLINIC_ID_NULL);

            RuleForEach(s => s.Appointments)
                .NotEmpty()
                .SetValidator(new AppointmentValidator());
        }
    }
}

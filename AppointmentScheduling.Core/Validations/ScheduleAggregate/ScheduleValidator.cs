using AppointmentScheduling.Core.AggregatesModel.ScheduleAggregate;
using AppointmentScheduling.Core.Constants;
using FluentValidation;

namespace AppointmentScheduling.Core.Validations.ScheduleAggregate
{
    public class ScheduleValidator : AbstractValidator<Schedule>
    {
        public ScheduleValidator()
        {
            RuleFor(s => s.ClinicId)
                .NotNull()
                .WithMessage(ErrorMessages.ERR_VALIDATION_SCHEDULE_CLINIC_ID_NULL);
        }
    }
}

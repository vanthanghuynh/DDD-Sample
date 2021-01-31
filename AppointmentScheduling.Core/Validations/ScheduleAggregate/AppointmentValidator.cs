using AppointmentScheduling.Core.AggregatesModel;
using AppointmentScheduling.Core.Constants;
using FluentValidation;

namespace AppointmentScheduling.Core.Validations
{
    public class AppointmentValidator : AbstractValidator<Appointment>
    {
        public AppointmentValidator()
        {
            RuleFor(a => a.ClientId)
                .NotNull()
                .WithMessage(ErrorMessages.ERR_VALIDATION_APPOINTMENT_CLIENT_ID_NULL);

            RuleFor(a => a.DoctorId)
                .NotNull()
                .WithMessage(ErrorMessages.ERR_VALIDATION_APPOINTMENT_DOCTOR_ID_NULL);

            RuleFor(a => a.RoomId)
                .NotNull()
                .WithMessage(ErrorMessages.ERR_VALIDATION_APPOINTMENT_ROOM_ID_NULL);

            RuleFor(a => a.AppointmentTypeId)
                .NotNull()
                .WithMessage(ErrorMessages.ERR_VALIDATION_APPOINTMENT_APPOINTMENT_TYPE_ID_NULL);
        }
    }
}

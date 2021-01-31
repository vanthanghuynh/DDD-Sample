using AppointmentScheduling.Core.AggregatesModel;
using AppointmentScheduling.Core.Constants;
using FluentValidation;

namespace AppointmentScheduling.Core.Validations
{
    public class RoomValidator : AbstractValidator<Room>
    {
        public RoomValidator()
        {
            RuleFor(r => r.Name)
                .NotEmpty()
                .WithMessage(ErrorMessages.ERR_VALIDATION_ROOM_NAME_EMPTY);
        }
    }
}

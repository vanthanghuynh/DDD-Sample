using AppointmentScheduling.Core.AggregatesModel.RoomAggregate;
using AppointmentScheduling.Core.Constants;
using FluentValidation;

namespace AppointmentScheduling.Core.Validations.RoomAggregate
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

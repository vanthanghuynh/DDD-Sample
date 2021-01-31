
namespace AppointmentScheduling.Core.Constants
{
    public static class ErrorMessages
    {
        public const string ERR_VALIDATION_CLIENT_FIRST_NAME_EMPTY = "Client validation: FirstName is required.";
        public const string ERR_VALIDATION_CLIENT_LAST_NAME_EMPTY = "Client validation: LastName is required.";
        
        public const string ERR_VALIDATION_PATIENT_CLIENT_ID_NULL = "Patient validation: ClientId is required.";
        public const string ERR_VALIDATION_PATIENT_ANIMAL_TYPE_NULL = "Patient validation: AnimalType is required.";
        public const string ERR_VALIDATION_PATIENT_GENDER_TYPE_NULL = "Patient validation: GenderType is required.";

        public const string ERR_VALIDATION_DOCTOR_FIRST_NAME_EMPTY = "Doctor validation: FirstName is required.";
        public const string ERR_VALIDATION_DOCTOR_LAST_NAME_EMPTY = "Doctor validation: LastName is required.";

        public const string ERR_VALIDATION_ROOM_NAME_EMPTY = "Room validation: Name is required.";

        public const string ERR_VALIDATION_APPOINTMENT_CLIENT_ID_NULL = "Appointment validation: ClientId is required.";
        public const string ERR_VALIDATION_APPOINTMENT_DOCTOR_ID_NULL = "Appointment validation: DoctorId is required.";
        public const string ERR_VALIDATION_APPOINTMENT_ROOM_ID_NULL = "Appointment validation: RoomId is required.";
        public const string ERR_VALIDATION_APPOINTMENT_APPOINTMENT_TYPE_ID_NULL = "Appointment validation: AppointmentTypeId is required.";
        
        public const string ERR_VALIDATION_SCHEDULE_CLINIC_ID_NULL = "Schedule validation: ClinicId is required.";
    }
}

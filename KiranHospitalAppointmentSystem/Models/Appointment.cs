using System;

namespace KiranHospitalAppointmentSystem.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public string PatientName { get; set; }
        public string    DoctorName { get; set; }

        public DateTime AppointmentDateTime { get; set; }
        public string ReasonForVisit { get; set; }
    }
}

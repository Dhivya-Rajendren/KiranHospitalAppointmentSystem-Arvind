using System.Collections.Generic;

namespace KiranHospitalAppointmentSystem.Models
{
    public interface IAppointmentRepository
    {
        //Read all the patient data
        //Read all the doctor data
        //Read all the appointment data

        List<Patient> GetAllPatiens();
        List<Doctor> GetAllDoctors();

        List<Appointment> GetAllAppointments();
    }
}

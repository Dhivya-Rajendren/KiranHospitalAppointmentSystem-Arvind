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

        // Add the data 
        List<Doctor> AddNewDoctor(Doctor doctor);

        void AddNewPatient(Patient patient);

        void DeletePatient(int patinetId);

        List<string> GetDoctorsAvailable();
    }
}

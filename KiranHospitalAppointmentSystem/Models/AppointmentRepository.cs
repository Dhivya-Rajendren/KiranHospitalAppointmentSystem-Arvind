using System.Collections.Generic;

namespace KiranHospitalAppointmentSystem.Models
{
    public class AppointmentRepository : IAppointmentRepository
    {
        public List<Doctor> AddNewDoctor(Doctor doctor)
        {
            List<Doctor> doctors = GetAllDoctors(); // Beginning there are 2 doctors
            doctors.Add(doctor);// Will add one more doctor in the list 
            return doctors;// we are returning 3
        }

        public void AddNewPatient(Patient patient)
        {
            throw new System.NotImplementedException();
        }

        public void DeletePatient(int patinetId)
        {
            throw new System.NotImplementedException();
        }

        public List<Appointment> GetAllAppointments()
        {
            throw new System.NotImplementedException();
        }

        public List<Doctor> GetAllDoctors()
        {
            Doctor doctor = new Doctor();
            doctor.DoctorId = 100;
            doctor.DoctorName = "Rajesh";
            doctor.Contact = 7856892312;
            doctor.Email = "Rajesh_cardio@gmail.com";
            doctor.SpecializedIn = "Cardio";
            doctor.YearsOfExperience = 15;

            List<Doctor> doctors = new List<Doctor>();
            doctors.Add(doctor);

            doctor = new Doctor();
            doctor.DoctorId = 101;
            doctor.DoctorName = "Priya";
            doctor.Contact = 7856892452;
            doctor.Email = "Priya_childcare@gmail.com";
            doctor.SpecializedIn = "Pedieo";
            doctor.YearsOfExperience = 15;
            doctors.Add(doctor);
            return doctors;

        }

        public List<Patient> GetAllPatiens()
        {

            Patient patient = new Patient();
            patient.PatientId = 1;
            patient.PatientName = "John";
            patient.Email = "John@outlook.com";
            patient.Contact = 7845122356;
            patient.PatientHistory = "No History";

            List<Patient> patients = new List<Patient>();
            patients.Add(patient);

            patient = new Patient();
            patient.PatientId = 2;
            patient.PatientName = "Priya";
            patient.Email = "priya@outlook.com";
            patient.Contact = 9945122356;
            patient.PatientHistory = "Ortho issues";

            patients.Add(patient);

            return patients;


        }

        public List<string> GetDoctorsAvailable()
        {
            throw new System.NotImplementedException();
        }

        //Ado .net -DB connection 
    }
}

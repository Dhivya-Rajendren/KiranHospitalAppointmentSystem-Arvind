using KiranHospitalAppointmentSystem.Models;
using KiranHospitalAppointmentSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KiranHospitalAppointmentSystem.Controllers
{
    public class PatientDoctorController : Controller
    {
        public IActionResult Index()
        {
            Doctor doctor = new Doctor();
            doctor.DoctorId = 1;
            doctor.DoctorName = "Kiran";
            doctor.Email = "Kiran@gmail.com";
            doctor.Contact = 789456123;
            doctor.SpecializedIn = "Cardio";

            Patient patient = new Patient();
            patient.PatientId = 100;
            patient.PatientName = "Kamal";
            patient.PatientHistory = "New Visit For Cardio";

            DoctorPatientViewModel viewModel = new DoctorPatientViewModel();
            viewModel.Doctor = doctor;
            viewModel.Patient = patient;


            return View(viewModel);
        }
    }
}

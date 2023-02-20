using Microsoft.AspNetCore.Mvc;
using KiranHospitalAppointmentSystem.Models;
using System.Collections.Generic;


namespace KiranHospitalAppointmentSystem.Controllers
{
    //www.KiranAppointment.com/Patients

    public class PatientsController : Controller
    {
        //default action method 
        public IActionResult Index()
        {
           AppointmentRepositoryFromSQL repo= new AppointmentRepositoryFromSQL();
            List<Patient> patients = repo.GetAllPatiens();
            return View(patients);
        }

      public IActionResult AddNewPatient()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewPatient(Patient patient)
        {
            AppointmentRepositoryFromSQL repo = new AppointmentRepositoryFromSQL();
            repo.AddNewPatient(patient);
            return RedirectToAction("Index");

        }

        public IActionResult Delete (int patientId)
        {
            AppointmentRepositoryFromSQL repo = new AppointmentRepositoryFromSQL();

            repo.DeletePatient(patientId);
            return RedirectToAction("Index");

        }



    }
}

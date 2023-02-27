using Microsoft.AspNetCore.Mvc;
using KiranHospitalAppointmentSystem.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace KiranHospitalAppointmentSystem.Controllers
{
    //www.KiranAppointment.com/Patients

    public class PatientsController : Controller
    {
        private readonly IAppointmentRepository repo;
        private readonly IConfiguration configuration;

        public PatientsController(IAppointmentRepository repo,IConfiguration configuration ) //Injecting the dependency here 
        {
            this.repo = repo;
            this.configuration = configuration;
        }


        //default action method 
        public IActionResult Index()
        {
            ViewBag.Key = configuration["myKey"];
            ViewBag.Author = configuration["Position:Author"];
            ViewBag.Role = configuration["Position:Role"];

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
         
            repo.AddNewPatient(patient);
            return RedirectToAction("Index");

        }

        public IActionResult PatientDetail(int patientId)
        {

            Patient patient = repo.GetAllPatiens().FirstOrDefault(p => p.PatientId == patientId);
           
            return View(patient);
        }

        public IActionResult Delete (int patientId)
        {

            Patient patient = repo.GetAllPatiens().FirstOrDefault(p => p.PatientId == patientId);
           // repo.DeletePatient(patientId);
            return View(patient);

        }

        public IActionResult ConfirmDelete(int patientId)
        {
            repo.DeletePatient(patientId);
            return RedirectToAction("Index");
        }


    }
}

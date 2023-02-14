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
            AppointmentRepository repo = new AppointmentRepository();
            List<Patient> patients = repo.GetAllPatiens();
          string pageTitle = "Patients Detail From View Bag";

            ViewBag.Title = pageTitle;

            List<string> patientsName = new List<string>() { "Geetha", "Rama", "Prem", "Kamal" };

            ViewBag.Patients = patientsName;
                  
            //return View(); // It is a empty View 
             // This is how we pass data from a controlelr to view using Models
                 return View(patients); //It is a view based on List of patients.
        }

       public IActionResult GetPatients()
        {
            string pageTitle = "Patients Detail from View Data";

            ViewData["Title"] = pageTitle;

            List<string> patientsName = new List<string>() { "Geetha", "Rama", "Prem", "Kamal" };

            ViewData["Patients"] = patientsName;

            return View();
        }
         public IActionResult GetAllPatients()
        {
            string pageTitle = "Patients Detail from Temp Data";

            TempData["Title"] = pageTitle;

            List<string> patientsName = new List<string>() { "Geetha", "Rama", "Prem", "Kamal" };

            TempData["Patients"] = patientsName;

            return View();
        }






    }
}

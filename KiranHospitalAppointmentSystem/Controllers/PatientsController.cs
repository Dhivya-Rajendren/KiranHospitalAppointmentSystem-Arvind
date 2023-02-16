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

       //public IActionResult GetPatients()
       // {
       //     string pageTitle = "Patients Detail from View Data";

       //     ViewData["Title"] = pageTitle;

       //     List<string> patientsName = new List<string>() { "Geetha", "Rama", "Prem", "Kamal" };

       //     ViewData["Patients"] = patientsName;

       //     return View();
       // }
       //  public IActionResult GetAllPatients()
       // {
       //     string pageTitle = "Patients Detail from Temp Data";

       //     TempData["Title"] = pageTitle;

       //     List<string> patientsName = new List<string>() { "Geetha", "Rama", "Prem", "Kamal" };

       //     TempData["Patients"] = patientsName;

       //     return View();
       // }






    }
}

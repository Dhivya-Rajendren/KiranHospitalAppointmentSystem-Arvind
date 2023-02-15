using Microsoft.AspNetCore.Mvc;

using KiranHospitalAppointmentSystem.Models;
using System.Collections.Generic;

namespace KiranHospitalAppointmentSystem.Controllers
{
    public class DoctorsController : Controller
    {
        public IActionResult Index()
        {
            AppointmentRepository repo = new AppointmentRepository();
            List<Doctor> doctors = repo.GetAllDoctors();
            return View(doctors);
        }

        public IActionResult GetDoctorById(int doctorID)
        {
            AppointmentRepository repo = new AppointmentRepository();
            List<Doctor> doctors = repo.GetAllDoctors();
            Doctor doc = doctors.Find(d=>d.DoctorId==doctorID);
            return View(doc);
        }

        public IActionResult AddNewDoctor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewDoctor(Doctor doctor)
        {
            AppointmentRepository repo = new AppointmentRepository();
           // repo.AddNewDoctor(doctor);
            ViewBag.Doctors = repo.AddNewDoctor(doctor);
            return View();
        }

    }
}

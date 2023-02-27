using Microsoft.AspNetCore.Mvc;
using KiranHospitalAppointmentSystem.Models;
using System.Collections.Generic;

namespace KiranHospitalAppointmentSystem.Components
{
    public class DoctorAvailableViewComponent:ViewComponent
    {
        private readonly IAppointmentRepository repo;

        public DoctorAvailableViewComponent(IAppointmentRepository repo)
        {
            this.repo = repo;
        }
    //    AppointmentRepositoryFromSQL repo = new AppointmentRepositoryFromSQL();


        public IViewComponentResult Invoke()
        {
            List<string> doctors = repo.GetDoctorsAvailable();
            return View(doctors);
        }
    }
}

namespace KiranHospitalAppointmentSystem.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string SpecializedIn { get; set; }
        public int YearsOfExperience { get; set; }
        public string Email { get; set; }
        public long Contact { get; set; }
    }
}

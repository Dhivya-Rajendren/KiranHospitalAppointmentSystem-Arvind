namespace KiranHospitalAppointmentSystem.Models
{
    public class Patient
    {
        //private int patientId;
        //private string patientName;
        //private string email;
        //private long contact;
        //private string patientHistory;


        //public int PatientId
        //{
        //    get
        //    {
        //        return patientId;
        //    }
        //    set
        //    {
        //        patientId = value;
        //    }
        //}

        //Auto implemented properties with no private varibles

      
        public int PatientId { get; set; }

        public string PatientName { get; set; }
        public string Email { get; set; }
        public long Contact { get; set; }
        public string PatientHistory { get; set; }


    }
}

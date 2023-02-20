using System.Collections.Generic;
using System.Data.SqlClient;

namespace KiranHospitalAppointmentSystem.Models
{
    public class AppointmentRepositoryFromSQL : IAppointmentRepository
    {
        //ADO .NET has classes used for connecting with Sql and executing the Sql
        // Use a provider for SQL Server 


        //Classes needed in ADO .Net 

        SqlConnection con = null; // Class used for making a connection between the application and database
        SqlCommand com= null;// class used for building and executing our SQL comand (DML)
        SqlDataReader reader = null;// Class used for fetching the data alone.

        public List<Doctor> AddNewDoctor(Doctor doctor)
        {
            throw new System.NotImplementedException();
        }



        public void AddNewPatient(Patient patient)//(string pName, string email, long contact,string pHistory)
        {
            string connectionString = "Server=Dhivya-pc\\Sqlexpress;database=AppointmentDB_BN4138;integrated security=true";
            con = new SqlConnection(connectionString);
            con.Open();
            com = new SqlCommand("insert into tbl_Patient values('" + patient.PatientName + "','" + patient.Email + "'," + patient.Contact + ",'" + patient.PatientHistory + "')", con);
            com.ExecuteNonQuery();//DML queries
        }

        public void DeletePatient(int patientId)
        {
            string connectionString = "Server=Dhivya-pc\\Sqlexpress;database=AppointmentDB_BN4138;integrated security=true";
            con = new SqlConnection(connectionString);
            con.Open();
            com = new SqlCommand("Delete from tbl_Patient where patientId=" + patientId, con);
            com.ExecuteNonQuery();
        }

        public List<Appointment> GetAllAppointments()
        {
            throw new System.NotImplementedException();
        }

        public List<Doctor> GetAllDoctors()
        {
            throw new System.NotImplementedException();
        }

        public List<Patient> GetAllPatiens()
        {
            string connectionString = "Server=Dhivya-pc\\Sqlexpress;database=AppointmentDB_BN4138;integrated security=true";
            con = new SqlConnection(connectionString);
            con.Open();
            com = new SqlCommand("Select * from tbl_patient", con);//Building the SQL query to run against our database 
            reader = com.ExecuteReader();//Execute the query .
            List<Patient> patients = new List<Patient>();
            while(reader.Read())
            {
                Patient patient = new Patient();
                patient.PatientId = reader.GetInt32(0);// First column
                patient.PatientName = reader.GetString(1);//second column 
                patient.Email = reader.GetString(2);
                patient.Contact = reader.GetInt64(3);
                patient.PatientHistory = reader.GetString(4);
                patients.Add(patient);
            }
            reader.Close();
            con.Close();
            return patients;
        }
    }
}

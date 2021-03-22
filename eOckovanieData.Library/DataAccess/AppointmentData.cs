using eOckovanieData.Library.Internal.DataAccess;
using eOckovanieData.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOckovanieData.Library.DataAccess
{
    public class AppointmentData
    {

        public List<AppointmentModel> GetAllAppointmentsForOneUser(string userId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new
            {
                Id = userId
            };

            var output = sql.LoadData<AppointmentModel, dynamic>("dbo.spGetAllAppointmentsForOneUser", p, "DefaultConnection");
            return output;
        }

        public List<AppointmentModel> GetSpecificAppointmentForUser(string userId,int appointmentId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new
            {
                Id = userId,
                appId = appointmentId
            };

            var output = sql.LoadData<AppointmentModel, dynamic>("dbo.spGetOneAppointmentForOneUser", p, "DefaultConnection");
            return output;
        }


        public List<AppointmentModel> GetAllAppointments()
        {
            SqlDataAccess sql = new SqlDataAccess();

            string p = null;

            var output = sql.LoadData<AppointmentModel, dynamic>("dbo.spGetAllAppointments", p, "DefaultConnection");
            return output;
        }


        public void Create(AppointmentCreateModel model)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var T = new
            {
                DoctorId = model.DocId,
                UserId = model.UserId,
                Time1 = model.Time1,
                Time2 = model.Time2,
                Status = model.Status,
                Location = model.Location,
                VaccineId = model.VacId,
                Date = model.Date

            };
            sql.SaveData<dynamic>("dbo.spCreateAppointment", T, "DefaultConnection");
        }
    }
}

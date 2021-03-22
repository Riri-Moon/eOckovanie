using eOckovanieData.Library.DataAccess;
using eOckovanieData.Library.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eOckovanie.Controllers
{
    [Authorize]
    [RoutePrefix("api/Appointment")]
    public class AppointmentController : ApiController
    {
        [Route("AppointmentsUser")]
        public List<AppointmentModel> GetAllAppointmentsForUser()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();

            AppointmentData data = new AppointmentData();

            return data.GetAllAppointmentsForOneUser(userId);
        }

        [Route("AppointmentUser")]
        public List<AppointmentModel> GetOneAppointmentForUser(int Id)
        {
            string userId = RequestContext.Principal.Identity.GetUserId();

            AppointmentData data = new AppointmentData();

            return data.GetSpecificAppointmentForUser(userId,Id);
        }

        [Route("All")]
        public List<AppointmentModel> GetAllAppointments()
        {

            AppointmentData data = new AppointmentData();

            return data.GetAllAppointments();
        }

        [Route("Create")]
        public void CreateAppointment(AppointmentCreateModel model)
        {

            model.UserId = RequestContext.Principal.Identity.GetUserId();

            AppointmentData data = new AppointmentData();
            data.Create(model);
        }

        [Route("Delete")]
        public void DeleteAppointment(int Id)
        {


            AppointmentData data = new AppointmentData();
          //  data.Create(model);
        }

        [Route("Update")]
        public void PutAppointment(AppointmentCreateModel model)
        {

            model.UserId = RequestContext.Principal.Identity.GetUserId();

            AppointmentData data = new AppointmentData();
          //  data.Create(model);
        }
    }
}

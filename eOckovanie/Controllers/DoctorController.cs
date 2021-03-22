using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using eOckovanieData.Library.DataAccess;
using eOckovanieData.Library.Models;

namespace eOckovanie.Controllers
{
    [Authorize]
    [RoutePrefix("api/Doctor")]
    public class DoctorController : ApiController
    {
        public List<DoctorModel> GetById(string id)
        {

            DoctorData data = new DoctorData();

            return data.GetDoctorById(id);
        }

        public List<DoctorModel> GetAllVaccines()
        {

            DoctorData data = new DoctorData();

            return data.GetAllDoctors();
        }

        [Route("Create")]
        public void CreateDoctor(DoctorModel model)
        {


            DoctorModel data = new DoctorModel();
           // data.Create(model);
        }

        [Route("Delete")]
        public void DeleteDoctor(int Id)
        {


            DoctorModel data = new DoctorModel();
            // data.Create(model);
        }

        [Route("Update")]
        public void PutDoctor(DoctorModel model)
        {


            DoctorModel data = new DoctorModel();
            // data.Create(model);
        }

    }
}

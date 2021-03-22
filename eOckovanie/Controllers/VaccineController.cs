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
    [RoutePrefix("api/Vaccine")]
    public class VaccineController : ApiController
    {
        public List<VaccineModel> GetById(string id)
        {

            VaccineData data = new VaccineData();

            return data.GetVaccineById(id);
        }

        public List<VaccineModel> GetAllVaccines()
        {

            VaccineData data = new VaccineData();

            return data.GetAllVaccines();
        }

        [Route("Create")]
        public void CreateVaccine(VaccineModel model)
        {


            VaccineModel data = new VaccineModel();
            // data.Create(model);
        }

        [Route("Delete")]
        public void DeleteVaccine(int Id)
        {


            VaccineModel data = new VaccineModel();
            // data.Create(model);
        }

        [Route("Update")]
        public void PutVaccine(VaccineModel model)
        {


            VaccineModel data = new VaccineModel();
            // data.Create(model);
        }


    }
}

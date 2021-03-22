using eOckovanieData.Library.Internal.DataAccess;
using eOckovanieData.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOckovanieData.Library.DataAccess
{
    public class VaccineData
    {
        public List<VaccineModel> GetVaccineById(string id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new
            {
                Id = id
            };

            var output = sql.LoadData<VaccineModel, dynamic>("dbo.spGetVaccineById", p, "DefaultConnection");
            return output;
        }

        public List<VaccineModel> GetAllVaccines()
        {
            SqlDataAccess sql = new SqlDataAccess();

            string p = null;

            var output = sql.LoadData<VaccineModel, dynamic>("dbo.spGetAllVaccines", p, "DefaultConnection");
            return output;
        }
    }
}

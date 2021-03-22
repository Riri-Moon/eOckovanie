using eOckovanieData.Library.Internal.DataAccess;
using eOckovanieData.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOckovanieData.Library.DataAccess
{
    public class DoctorData
    {
        public List<DoctorModel> GetDoctorById(string id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new
            {
                Id = id
            };

            var output = sql.LoadData<DoctorModel, dynamic>("dbo.spGetDoctorById", p, "DefaultConnection");
            return output;
        }

        public List<DoctorModel> GetAllDoctors()
        {
            SqlDataAccess sql = new SqlDataAccess();

            string p = null;

            var output = sql.LoadData<DoctorModel, dynamic>("dbo.spGetAllDoctors", p, "DefaultConnection");
            return output;
        }
    }
}

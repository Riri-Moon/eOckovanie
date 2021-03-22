﻿using eOckovanieData.Library.Internal.DataAccess;
using eOckovanieData.Library.Models;
using System.Collections.Generic;

namespace eOckovanieData.Library.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new
            {
                Id = id
            };

            var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", p, "DefaultConnection");
            return output;
        }
    }
}

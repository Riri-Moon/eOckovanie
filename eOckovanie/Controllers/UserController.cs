using eOckovanieData.Library.DataAccess;
using eOckovanieData.Library.Models;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace eOckovanie.Controllers
{
    [Authorize]
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {

        public UserModel GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();

            UserData data = new UserData();

            return data.GetUserById(userId).First() ;
        }
    }
}

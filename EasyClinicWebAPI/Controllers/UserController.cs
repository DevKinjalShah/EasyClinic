using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using EasyClinicModel.Model;
using EasyClinicIBL.Repository;
using EasyClinicBL;

namespace EasyClinicWebAPI.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        private  IUserRepository iUserRepository;

        public UserController(IUserRepository _iUserRepository)
        {
            iUserRepository = _iUserRepository;
        }

        [Route("GetUser")]
        public IEnumerable<UserModel> Get() {

            var userList = iUserRepository.GetAllUser();
            return userList;
        }
    }
}

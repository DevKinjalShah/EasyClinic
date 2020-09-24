using EasyClinicData;
using EasyClinicIBL.Repository;
using EasyClinicModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyClinicBL
{
    public class UserRepository : IUserRepository
    {
        private EasyClinicDBEntities ObjEasyClinicDBEntities;
        public UserRepository()
        {
            ObjEasyClinicDBEntities = new EasyClinicDBEntities();
        }

        public int AddBook(UserModel obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetAllUser()
        {
                IEnumerable<UserModel> list = (from u in ObjEasyClinicDBEntities.Users
                                               select new UserModel
                                               {
                                                   UserId = u.UserId,
                                                   UserName = u.UserName,
                                                   FirstName = u.FirstName,
                                                   LastName = u.LastName,
                                                   Password = u.Password,
                                                   Email = u.Email,
                                                   ValidFlag = u.ValidFlag
                                               }).ToList();
            return list;
            
        }

        public UserModel GetBookById(long id)
        {
            throw new NotImplementedException();
        }
    }
}

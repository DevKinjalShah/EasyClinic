using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyClinicModel.Model;
namespace EasyClinicIBL.Repository
{
    public interface IUserRepository
    {
        IEnumerable<UserModel> GetAllUser();

        int AddBook(UserModel obj);

        UserModel GetBookById(long id);
    }
}

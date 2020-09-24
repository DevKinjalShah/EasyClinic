using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyClinicModel.Model
{
   public class UserModel
    {
        public long UserId { get; set; }
        [StringLength(maximumLength: 200)]
        public string UserName { get; set; }
        [StringLength(maximumLength: 100)]
        public string Password { get; set; }
        [StringLength(maximumLength: 50)]
        public string FirstName { get; set; }
        [StringLength(maximumLength: 50)]
        public string LastName { get; set; }
        [StringLength(maximumLength: 100)]
        public string Email { get; set; }
        [StringLength(maximumLength: 100)]
        public string Phone { get; set; }
        public bool AuthenticationStatus { get; set; }
        public bool ActiveStatus { get; set; }
        public bool ValidFlag { get; set; }
        public long UserIdCreated { get; set; }
        public DateTime CreatedDate { get; set; }
        public long UserIdUpdated { get; set; }
        public DateTime UpdtedDate { get; set; }

    }
}

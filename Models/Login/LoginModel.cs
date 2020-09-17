using RemoteServerAccess.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteServerAccess.Models.Login
{
    public class LoginModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string SystemUserName { get; set; }
        public string DateTimeStamp { get; set; }

        public static BusinessContext _Context;
        public LoginModel()
        {

        }
        public LoginModel(BusinessContext Context)
        {
            _Context = Context;
        }
        public string GetUserNameFromSystemName(string systemUserName)
        {
            UserDetails_Business userDetails_Business = new UserDetails_Business(_Context);
            var userName = userDetails_Business.getNamefromSystemName(systemUserName);
            return userName;
        }
    }    
}

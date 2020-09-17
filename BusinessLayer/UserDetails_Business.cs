using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteServerAccess.BusinessLayer
{
    public class UserDetails_Business
    {
        public readonly BusinessContext _Context;

        public UserDetails_Business()
        {

        } 
        public UserDetails_Business(BusinessContext Context)
        {
            _Context = Context;
        }

        public string getNamefromSystemName(string systemUserName) 
        {
            var userName = _Context.UserDetails.Where(x => x.SystemUserName == systemUserName).Select(x => x.UserName)?.FirstOrDefault();
            return userName;
        }

        //public string getSystemNamefromUserName(string userName)
        //{
        //    var systemUserName = _Context.UserDetails.Where(x => x.UserName == userName).Select(x => x.SystemUserName)?.FirstOrDefault();
        //    return userName;
        //}
    }
}

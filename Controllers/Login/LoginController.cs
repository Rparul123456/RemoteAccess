using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RemoteServerAccess.BusinessLayer;
using RemoteServerAccess.Models.Login;
using RemoteServerAccess.Models.RemoteServerDetails;

namespace RemoteServerAccess.Controllers.Login
{
    public class LoginController : Controller
    {
        public static BusinessContext _Context;
        public LoginController(BusinessContext Context)
        {
            _Context = Context;
        }
        // GET: Login
        public ActionResult Login()
        {
            bool testUser = false;
            string systemUserName;
            if (testUser)
            {
                systemUserName = "AP\\ranaasur";
            }
            else
            {
                systemUserName = HttpContext.User.Identity.Name.ToString();
            }

            var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
            //identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, userName));
            identity.AddClaim(new Claim(ClaimTypes.Name, systemUserName));
            var principal = new ClaimsPrincipal(identity);
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties
            {
                IsPersistent = false,
                ExpiresUtc = DateTime.UtcNow.AddHours(20)
            });

            LoginModel loginModel = new LoginModel(_Context);
           // var systemUser = systemUserName.Replace(@"\", string.Empty);
            var userName = loginModel.GetUserNameFromSystemName(systemUserName);



            HttpContext.Session.SetString("UserName", userName);
            ViewBag.currentUser = userName;

            RSDetails rSDetails = new RSDetails(_Context);
            var rsList = rSDetails.GetDetailsOfRemoteServers();
            return View("../RemoteServerDetails/RemoteServerDetails", rsList);
        }

        [HttpPost]
        public ActionResult Login(LoginModel login)
        {
            return View();

        }


        //public static string GetFullName(string strLogin)
        //{
        //    string str = "";
        //    string strDomain;
        //    string strName;
        //    // Parse the string to check if domain name is present.
        //    int idx = strLogin.IndexOf('\\');
        //    if (idx == -1)
        //    {
        //        idx = strLogin.IndexOf('@');
        //    }
        //    if (idx != -1)
        //    {
        //        strDomain = strLogin.Substring(0, idx);
        //        strName = strLogin.Substring(idx + 1);
        //    }
        //    else
        //    {
        //        strDomain = Environment.MachineName;
        //        strName = strLogin;
        //    }
        //    DirectoryEntry obDirEntry = null;
        //    try
        //    {
        //        obDirEntry = new DirectoryEntry("WinNT://" + strDomain + "/" + strName);
        //        System.DirectoryServices.PropertyCollection coll = obDirEntry.Properties;
        //        object obVal = coll["FullName"].Value;
        //        str = obVal.ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        str = ex.Message;
        //    }
        //    return str;
        //}
    }
}
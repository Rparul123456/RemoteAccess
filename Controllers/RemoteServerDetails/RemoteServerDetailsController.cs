using System;
using Microsoft.AspNetCore.Mvc;
using RemoteServerAccess.BusinessLayer;
using RemoteServerAccess.Models.RemoteServerDetails;
using Microsoft.AspNetCore.Http;

namespace RemoteServerAccess.Controllers.RemoteServerDetails
{
    public class RemoteServerDetailsController : Controller
    {
        public static BusinessContext _Context;
        public RemoteServerDetailsController(BusinessContext Context)
        {
            _Context = Context;
        }

        // GET: RemoteServerDetails/GetDetailsOfRemoteServers
        [HttpGet]
        public ActionResult GetData()
        {
            RSDetails details = new RSDetails(_Context);
            var rsList = details.GetDetailsOfRemoteServers();
            ViewBag.currentUser = HttpContext.Session.GetString("UserName");
            return View("RemoteServerDetails", rsList);
        }

        // POST: RemoteServerDetails/SaveData
        [HttpPost]
        public JsonResult UpdateData([FromBody]RSDetails rSDetails )
        {
            try
            {
                rSDetails.UpdateDetailsOfRemoteServers(rSDetails);
                return Json(Url.Action("GetData", "RemoteServerDetails"));
            }
            catch(Exception ex)
            {
                return Json(ex);
            }
        }
    }
}
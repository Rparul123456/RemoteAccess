using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RemoteServerAccess.Models.RemoteServerDetails;

namespace RemoteServerAccess.BusinessLayer
{
    public class RSDetails_Business
    {
        public readonly BusinessContext _Context;
        public RSDetails_Business(BusinessContext Context)
        {
            _Context = Context;
        }
        public List<RSDetails> GetAllDetailsOfRemoteServers()
        {
            var rsList = _Context.RemoteServerAccessInfo.ToList();
            return rsList;
        }

        public void UpdateAllDetailsOfRemoteServers(RSDetails rSDetails)
        {
            // _Context.RemoteServerAccessInfo.Attach(rSDetails);
            var updtdata = _Context.RemoteServerAccessInfo.FirstOrDefault(x => x.ID == rSDetails.ID);
            updtdata.USER_S_ACCESS_BY = rSDetails.USER_S_ACCESS_BY;
            updtdata.USER_P_ACCESS_BY = rSDetails.USER_P_ACCESS_BY;
            _Context.RemoteServerAccessInfo.Update(updtdata);
            _Context.SaveChanges();
        }
    }
}

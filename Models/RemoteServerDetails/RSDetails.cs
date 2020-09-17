using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RemoteServerAccess.BusinessLayer;

namespace RemoteServerAccess.Models.RemoteServerDetails
{
    public class RSDetails
    {
        [Key]
        public Int64 ID { get; set; }
        public string ServerName { get; set; }
        public string USER_S_ACCESS_BY { get; set; }
        public bool ISACTIVE_S { get; set; }
        public string USER_P_ACCESS_BY { get; set; }
        public bool ISACTIVE_P { get; set; }
        public string DateTimeStamp { get; set; }

        public static BusinessContext _Context;

        public RSDetails()
        {

        }
        public RSDetails(BusinessContext Context)
        {
            _Context = Context;
        }
        public List<RSDetails> GetDetailsOfRemoteServers()
        {
            RSDetails_Business rSDetails_Business = new RSDetails_Business(_Context);
            var rsList = rSDetails_Business.GetAllDetailsOfRemoteServers();
            return rsList;
        }

        public void UpdateDetailsOfRemoteServers(RSDetails rSDetails)
        {
            RSDetails_Business rSDetails_Business = new RSDetails_Business(_Context);
            rSDetails_Business.UpdateAllDetailsOfRemoteServers(rSDetails);

        }
    }
}

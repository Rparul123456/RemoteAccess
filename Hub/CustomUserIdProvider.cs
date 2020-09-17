using Microsoft.AspNetCore.SignalR;

namespace RemoteServerAccess.Hub
{
    public class CustomUserIdProvider : IUserIdProvider
    {
        public virtual string GetUserId(HubConnectionContext connection)
        {
            bool testUser = false;
            string userName;
            if (testUser)
                userName = "AP\\ranaasur";
            else
                userName = connection.User.Identity.Name;

            return userName.ToString();
                                                          }
    }
}

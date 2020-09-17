using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RemoteServerAccess.BusinessLayer;
using RemoteServerAccess.Models.RemoteServerDetails;
using RemoteServerAccess.Models.Login;

namespace RemoteServerAccess.BusinessLayer
{
    public class BusinessContext : DbContext
    {
        public BusinessContext(DbContextOptions<BusinessContext> options) : base(options)
        {

        }
        public DbSet<RSDetails> RemoteServerAccessInfo { get; set; }

        public DbSet<LoginModel> UserDetails { get; set; }
    }
}

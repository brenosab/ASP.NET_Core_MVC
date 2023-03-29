using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPNET_Core_MVC.Models;

namespace ASPNET_Core_MVC.Data
{
    public class ASPNET_Core_MVCContext : DbContext
    {
        public ASPNET_Core_MVCContext (DbContextOptions<ASPNET_Core_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNET_Core_MVC.Models.Info> Info { get; set; }
    }
}

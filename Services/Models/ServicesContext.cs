using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Services.Models
{
    public class ServicesContext : DbContext
    {
        public DbSet<Service> Services { get; set; }

        public DbSet<Requester> Requesters { get; set; }

        public ServicesContext()
            :base("name=DefaultConnection")
        {

        }
    }
}
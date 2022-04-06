using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int ServiceDuration { get; set; }
        public int ServiceCost { get; set; }
        public bool Active { get; set; }
    }
}
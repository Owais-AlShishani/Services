using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.ViewModels
{
    public class ServicesViewModels
    {
        public Service Service { get; set; }
        public List<Requester> Requester { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Services.Models
{
    public class Requester
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewLetter { get; set; }
        public MemberShipType MemberShipType { get; set; }

        public byte MemberShipTypeId { get; set; }

    }
}
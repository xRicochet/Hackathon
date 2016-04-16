using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon.Data
{
    public class Check_In:BaseEntity
    {
        public int UserId { get; set; }

        public int PartyId { get; set; }

        public String Message { get; set; }
    }
}
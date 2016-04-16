using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon.Data
{
    public class Commentaries:BaseEntity
    {
        public int UserId { get; set; }
        public int PartyId { get; set; }
        public String Message { get; set; }
    }
}
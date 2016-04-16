using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon.Data
{
    public class Pics:BaseEntity
    {
        public int UserId { get; set; }
        public int PartyId { get; set; }
        public String PicturePath { get; set; }
    }
}
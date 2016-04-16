using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon.Data
{
    public class NoiseComplaints:BaseEntity
    {
        public int PartyId { get; set; }
        public int UserId { get; set; }
        public int decibels { get; set; }
    }
}
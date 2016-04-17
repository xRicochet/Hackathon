using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon.Data
{
    public class Party :BaseEntity
    {
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }
        public float LocationLongitude { get; set; }
        public float LocationLattitude { get; set; }
        public string LocationName { get; set; }
        public List<string> Pics { get; set; }
    }
}
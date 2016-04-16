using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon.Data
{
    public class Party
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }
        public float LocationLong { get; set; }
        public float LocationLat { get; set; }
        public string LocationName { get; set; }
    }
}
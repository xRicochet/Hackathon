using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public bool IsApproved { get; set; }
        public string UserToken { get; set; }
        public string FacebookId { get; set; }
        public string GoogleId { get; set; }
        public string ProfilePhoto { get; set; }
    }
}
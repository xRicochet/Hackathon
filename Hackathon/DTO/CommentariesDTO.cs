using Hackathon.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon.DTO
{
    public class CommentariesDTO : Commentaries
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
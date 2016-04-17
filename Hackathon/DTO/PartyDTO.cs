using Hackathon.Data;
using Hackathon.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon.DTO
{
    public class PartyDTO : Party
    {
       public List<String> photoPaths { get; set; }
       public List<User> partyPPL { get; set; }
       public List<CommentariesDTO> Commentaries {get; set;}
    }
}
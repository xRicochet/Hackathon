using Hackathon.Data;
using Hackathon.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon.DTO
{
    public class PartyDTO:Party
    {
        List<String> photoPaths { get; set; }
        List<User> partyPPL { get; set; }
    }
}
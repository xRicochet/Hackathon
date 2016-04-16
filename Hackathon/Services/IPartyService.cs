using Hackathon.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Services
{
    public interface IPartyService
    {
        Party GetPartyByID(int PartyId);
        List<Party> GetAllParties();

        List<String> GetPicsFromParty(int PartyId);
    }
}

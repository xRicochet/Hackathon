using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
using Dapper;
using Hackathon.Data;

namespace Hackathon.Services
{
    public class PartyService : IPartyService
    {
        public static readonly string partyQuery = "Select p.* from Party p ";
        
        public Party GetPartyByID(int PartyId)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                connection.Open();
                var user = connection.Query<Party>(String.Concat(partyQuery, "where p.Id = ", PartyId)).SingleOrDefault();
                connection.Close();
                return user;
            }
        }
        public List<Party> GetAllParties()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                connection.Open();
                var user = connection.Query<Party>(partyQuery).ToList();
                connection.Close();
                return user;
            }
        }

        public List<String> GetPicsFromParty(int PartyId)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                connection.Open();
                var user = connection.Query<String>("Select p.PicturePath from Pics p where p.PartyId=@PartyId",new { PartyId }).ToList();
                connection.Close();
                return user;
            }
        }

    }
}
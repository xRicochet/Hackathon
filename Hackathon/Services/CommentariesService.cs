using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
using Dapper;
using Hackathon.Data;

namespace Hackathon.Services
{
    public class CommentariesService
    {
        public List<Commentaries> GetAllCommentariesAtAParty(int PartyId)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                connection.Open();
                var commentaries = connection.Query<Commentaries>("Select c.* from Commentaries c where c.PartyId=@PartyId", new { PartyId}).ToList();
                connection.Close();
                return commentaries;
            }
        }
    }
}
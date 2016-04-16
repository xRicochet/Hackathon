using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
using Dapper;

namespace Hackathon.Services
{
    public class UserService
    {
        public static readonly string userQuery = "Select u.* from Users u where u.Id = ";
        public User GetUser(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                SqlCommand command = new SqlCommand(String.Concat(userQuery,id), connection);


                connection.Open();
                var user = connection.Query<User>(String.Concat(userQuery, id)).SingleOrDefault();
                return user;
            }
        }
    }
}
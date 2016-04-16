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
    public class UserService : IUserService
    {
        public static readonly string userQuery = @"Select u.* from Users u ";

        public User GetUserById(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                
                connection.Open();
                var user = connection.Query<User>(String.Concat(userQuery, "where u.Id = ", id)).SingleOrDefault();
                connection.Close();
                return user;
            }
        }

        public User GetUserByEmail(String Email)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                connection.Open();
                var user = connection.Query<User>(@String.Concat(userQuery, "where u.Email = '"+ Email+"'")).SingleOrDefault();
                connection.Close();
                return user;
            }
        }

        public List<User> GetAllUsers() 
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                connection.Open();
                var user = connection.Query<User>(userQuery).ToList();
                connection.Close();
                return user;
            }
        }

        public List<User> GetUsersAtAParty(int PartyId)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                connection.Open();
                var user = connection.Query<User>(String.Concat(userQuery, "join PartyPPL p on u.Id=p.UserId where p.PartyId = ", PartyId)).ToList();
                connection.Close();
                return user;
            }
        }

        public User GetUserByEmailAndPassword(String email,String password)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                connection.Open();
                var user = connection.Query<User>(String.Concat(userQuery, "where u.Email = '"+email+"' AND u.Password = '"+password+"'"),new { password }).SingleOrDefault();
                connection.Close();
                return user;
            }
        }

        public List<User> GetUserFriends(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                connection.Open();
                //var user = connection.Query<User>(String.Concat(userQuery, "join Friends f on f.UserId=u.Id join Users u1 on u1.Id=f.FriendId where u.Id= ", id)).ToList();
                var user = connection.Query<User>("Select u.* from Friends f join Users u on u.Id=f.FriendId where f.UserId=@id AND f.FriendId!=@id", new { id }).ToList();

                connection.Close();
                return user;
            }
        }
        
    }
}
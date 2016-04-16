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
    public class ChatMessengerService
    {
        public List<String> GetChatMessages(int chatId)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                connection.Open();
                var messages = connection.Query<String>( "Select c.Message from ChatMessenger c where c.ChatId=@chatId", new { chatId }).ToList();
                connection.Close();
                return messages;
            }
        }
        public List<User> GetChatUsers(int chatId)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                connection.Open();
                var users = connection.Query<User>("Select u.* from ChatMessenger c join Users u on u.Id=c.UserId where c.ChatId=@chatId", new { chatId }).ToList();
                connection.Close();
                return users;
            }
        }
    }
}
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
    public interface IChatMessengerService
    {
         List<String> GetChatMessages(int chatId);
         List<User> GetChatUsers(int chatId);
    }
}
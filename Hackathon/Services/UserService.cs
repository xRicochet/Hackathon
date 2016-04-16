﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
using Dapper;
using Hackathon.Data;

namespace Hackathon.Services
{
    public class UserService
    {
        public static readonly string userQuery = "Select u.* from Users u ";
        public User GetUser(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                connection.Open();
                var user = connection.Query<User>(String.Concat(userQuery, "where u.Id = ", id)).SingleOrDefault();
                connection.Close();
                return user;
            }
        }
    }
}
using Hackathon.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Services
{
    public interface IUserService
    {
        User GetUserById(int id);

        User GetUserByEmail(String Email);

        List<User> GetAllUsers();

        List<User> GetUsersAtAParty(int PartyId);

        User GetUserByEmailAndPassword(String Email, String Password);

        List<User> GetUserFriends(int id);

    }
}

